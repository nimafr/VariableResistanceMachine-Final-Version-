using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CMLCOMLib;
using System.IO.Ports;

namespace TeamMusclesAndMachine
{


    public partial class workout_screen : Form
    {
        const int WEIGHT_THRESHOLD = 20;
        const int ACCELERATION_DEFAULT = 25;
        const int SPEED_DEFAULT = 5;
        const int SPEED_LIMIT = 25;
        const int START_POS_DEFAULT = 0;
        const int END_POS_DEFAULT = 95;
        const int ZERO_POS_DEFAULT = 0;
        const int MOVE_INCREMENT = 5;
        const double MOTOR_INCREMENT_MOVE = 49;


        //***************************************************
        //
        //  CANOpen Network 
        //
        //***************************************************

        canOpenObj canOpen;
        AmpObj xAxisAmp;
        ProfileSettingsObj ProfileSettings;
        ampSettingsObj ampSettings;
        eventObj xAxisEventObj;
        short X_AXIS_CAN_ADDRESS = 1;

        bool motorConnect = false;
        bool automove = false;
        bool direction = false;
        bool motormoving = false;
        bool motorStartStop = true;

        string buffer;
        int offset;
        int setSelection = 0;
        int totalReps = 0;
        int startPos, stopPos, currSpeed;
        int sec = 0;
        int total_time_sec = 0;
        int min = 0;
        string time;

        double max_weight = 0;
        double totalWeight = 0;
        double avg_weight;
        daemon d = new daemon();

        private void xAxisEventObj_EventNotify(CML_AMP_EVENT match, bool hasError)
        {
            
            try
            {
                if(direction == false)
                {
                    direction = true;
                    totalReps = totalReps + 1;
                    AutoMoveMotor(true);
                    
                }
                else
                {
                    direction = false;
                    AutoMoveMotor(false);
                }
                
            }
            catch (Exception ex)
            {
                xAxisAmp.HaltMove();
                xAxisEventObj.Stop();
                xAxisAmp.ClearFaults();
                automove = false;
                motorButton.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.Start_button;
                DisplayErrorPopup("Auto Move Error", "Auto Move Error: 200");
                
            }

        }
        
        
        //***************************************************
        // Default Constructor
        // new workout => set range of start and stop to 0 & 95
        // then gets users start and stop position
        //***************************************************
        public workout_screen(String workout_name)
        {
            // Initilize window screen
            InitializeComponent();

            // Updates Name of workout in screen
            workout_name_label.Text = workout_name;

            // Initilize variable to defaults states
            this.startPos = START_POS_DEFAULT;                      // Default start position = min distance (0)
            this.stopPos = END_POS_DEFAULT;                      // Default stop position = max distance (90)
            

            // set default speed
            setSpeed(SPEED_DEFAULT);

            // workout_livechart.ChartAreas[0].AxisX.Title = "xxx";
            createlivechart();

            // Connect to Motor
            Motor_Connect();

            // Connect to Arduino
            connectArduino();

            // recalibrate zero position
            calibratePositionZero();

            // Initilize Actuator Motor -> reset to zero position
            setActuatorPositionZero();
            
            // update linear position on bar
            updateActuatorPositionBar();

            // set start/stop markers 
            setMarkers();

            // get user start position
            showSetPositionDisplay(0);
        }

        //***************************************************
        // Default Constructor
        // new workout => set range of start and stop to 0 & 95
        // then gets users start and stop position
        //***************************************************
        public workout_screen(String workout_name, int start_Pos, int stop_Pos)
        {
            // Initilize window screen
            InitializeComponent();
            // Updates Name of workout in screen
            workout_name_label.Text = workout_name;

            // Initilize variable to defaults states
            this.startPos = START_POS_DEFAULT;                      // Default start position = min distance (0)
            this.stopPos = END_POS_DEFAULT;                      // Default stop position = max distance (90)


            // set default speed
            setSpeed(SPEED_DEFAULT);

            // workout_livechart.ChartAreas[0].AxisX.Title = "xxx";
            createlivechart();

            // Connect to Motor
            Motor_Connect();

            // Connect to Arduino
            connectArduino();

            // recalibrate zero position
            calibratePositionZero();

            // Initilize Actuator Motor -> reset to zero position
            setActuatorPositionZero();

            // update linear position on bar
            updateActuatorPositionBar();

            // set custom start & stop position
            setStartStopPositions(start_Pos, stop_Pos);
        }
        public int updateActuatorPositionBar()
        {
            try
            {
                // Linear Position => value between 0-90
                double curr_postion = xAxisAmp.PositionActual;
                curr_postion = curr_postion + 1;
                curr_postion = curr_postion / 10;
                
                if (curr_postion >= 0)
                {
                    progressBarActuator.Value = (int) curr_postion;
                }
                else
                {
                    progressBarActuator.Value = 0;
                }

                return (int) curr_postion;

            }
            catch
            {
                DisplayErrorPopup("Current Position Error", "Error while trying to get current position of motor failed.");
            }
            return -1;
        }

        public void setSpeed(int speed) //*use this to manually update speed displays*
        {
            speedDisplayLabel.Text = speed.ToString();
            currSpeed = speed;
        }

        public void updateRTWeight(double weight) //*use this to update real time force*
        {
            int wt = (int)weight;
            RTDisp.Text = wt.ToString();
        }

        public void updateMaxWeight(double weight) //*use this to update max force*
        {
            int wt = (int)weight;
            MAXDisp.Text = wt.ToString();
        }

        public void updateAvgWeight(double weight) //*use this to update avg force*
        {
            int wt = (int)weight;
            AVGDisp.Text = wt.ToString();
        }

        public void updateReps(int reps) //*use this to update reps*
        {
            REPSDisp.Text = reps.ToString();
        }

        private void connectArduino()
        {
            try
            {
                arduinoPort = new SerialPort("COM5", 9600);
                arduinoPort.Open();
                arduinoPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                buffer = string.Empty;

            }
            catch
            {

            }

        }

        private void back_button_Click(object sender, EventArgs e)
        {

            // Safely close connection to Motor
            //////////////////////////////////// TODO FIX /////////////////////////////////////
            if (motorConnect)
            {
                //xAxisEventObj.Stop();
                //xAxisAmp.HaltMove();
                xAxisAmp.Disable();
                canOpen.Close();
            }

            // Safely closes Serial Port to Arduino
            if (arduinoPort.IsOpen)
            {
                arduinoPort.Dispose();
                arduinoPort.Close();
            }


            d.add_to_whistory("JOSE", 0, time, "0", totalReps, (int)max_weight, (int)avg_weight);

            this.Hide();
            var choose_workout_screen = new choose_workout_screen();
            choose_workout_screen.FormClosed += (s, args) => this.Close();
            choose_workout_screen.Show();
        }

        ///////////////////////////////////////////////////////////////////////////////
        /// 
        ///
        ///////////////////////////////////////////////////////////////////////////////
        private void Motor_Connect()
        {

            try
            {
                xAxisAmp = new AmpObj();

                //***************************************************
                //
                //  CANOpen Network
                //
                //***************************************************
                canOpen = new canOpenObj();                         // Set the bit rate to 1 Mbit per second
                canOpen.BitRate = CML_BIT_RATES.BITRATE_1_Mbit_per_sec;
                canOpen.PortName = "copley0"; // Indicate that channel 0 of a Copley CAN card should be used
                ampSettings = new ampSettingsObj();

                //***************************************************
                // Initialize the CAN card and network
                //***************************************************
                canOpen.Initialize();
                canOpen.ClearErrorFrameCounter();

                // CHANGE CAN Address -> based on settings
                //X_AXIS_CAN_ADDRESS = (short) X_AXIS_CAN_ADDRESS;                  // Sets CAN address to connect to


                //***************************************************
                //* Initialize the Amplifier (Stepnet)
                //***************************************************
                ampSettings.enableOnInit = true;
                xAxisAmp.InitializeExt(canOpen, X_AXIS_CAN_ADDRESS, ampSettings);
                xAxisAmp.ClearFaults();                                             // Clear Errors
                //xAxisAmp.StopGuarding();


                //***************************************************
                //* Create Event Handler for the Amplifier (Stepnet)
                //***************************************************
                xAxisEventObj = xAxisAmp.CreateEvent(CML_AMP_EVENT.AMPEVENT_MOVE_DONE, CML_EVENT_CONDITION.CML_EVENT_ANY);
                xAxisEventObj.EventNotify += new eventObj.EventHandler(xAxisEventObj_EventNotify);
                             

                motorConnect = true;                                                                // Motor Connected Successful
                motorButton.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.Start_button;

            }
            catch (Exception ex)
            {
                motorButton.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.Connect_button;
                //DisplayErrorPopup("Linear Actuator Error", "Connection to Stepnet failed. Check that device is " +
                //                                        "connected and CAN Channel selected is correct.");
            }

        }



        private void moveMotor(int speed, int acceleration, int distance)
        {
            double vel, accel, dist;

            // test speed
            vel = Convert.ToDouble(speed+10) * 10;
            accel = Convert.ToDouble(acceleration) * 100;
            dist = Convert.ToDouble(distance) * 10;

            ProfileSettings = xAxisAmp.ProfileSettings; // read profile settings from amp

            //Set the profile type for move
            ProfileSettings.ProfileType = CML_PROFILE_TYPE.PROFILE_TRAP;

            //Set the profile trajectory values 
            ProfileSettings.ProfileAccel = accel;
            ProfileSettings.ProfileDecel = accel;
            ProfileSettings.ProfileVel = vel;

            // Update the amplier's profile settigns
            xAxisAmp.ProfileSettings = ProfileSettings;
            
            xAxisAmp.Enable();                                          // Enable Motor
            xAxisAmp.MoveAbs(dist);                                     // Execute the move
            
        }
        
        public void DisplayErrorPopup(String source, String message)
        {
            DialogResult errormsgbox = new DialogResult();
            MessageBox.Show("ERROR: " + message, source, MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (errormsgbox == DialogResult.Cancel)
            {
                // GUI thread - if this is the case we must use a delegate to close the application.
                //Dim d As New CloseApp(AddressOf ThreadSafeClose)
                CloseApp d = new CloseApp(ThreadSafeClose);
                this.Invoke(d);
            }
        }

        public void ThreadSafeClose()
        {
            //If the calling thread is different than the GUI thread, then use the
            //delegate to close the application, otherwise call close() directly
            if (this.InvokeRequired)
            {
                CloseApp d = new CloseApp(ThreadSafeClose);
                this.Invoke(d);
            }
        }

        // Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();

        // true => goes to start position
        // false => goes to stop position
        private void AutoMoveMotor(bool startDirection)
        {
            automove = true;
           
            if (Convert.ToInt32(startPosSelect.Text) != 0)
            {
                startPos = Convert.ToInt32(startPosSelect.Text);
            }
            if (Convert.ToInt32(endPosSelect.Text) != 0)
            {
                stopPos = Convert.ToInt32(endPosSelect.Text);
            }

            // start motor movement
            if (startDirection)
            {
                moveMotor(currSpeed, ACCELERATION_DEFAULT, startPos);
            }
            else
            {
                moveMotor(currSpeed, ACCELERATION_DEFAULT, stopPos);
            }
            
        }

        private void motorButton_Click(object sender, EventArgs e)
        {
            motorButton.Enabled = false;
            try
            {
                // Motor is connected
                if (motorConnect == false)
                {
                    Motor_Connect();
                }
                // Set Start and Stop Position Linear Actuator
                else if (motorStartStop == false)
                {
                    // set start position
                    if(setSelection == 0)
                    {
                        startPos = progressBarActuator.Value;

                        moveMotor(8, ACCELERATION_DEFAULT, 95);
                        xAxisAmp.WaitMoveDone(-1);

                        updateActuatorPositionBar();

                        // show stop position display
                        showSetPositionDisplay(1);
                        
                        setSelection = 1;
                        
                    }
                    // set stop position
                    else if(setSelection == 1)
                    {
                        // hide set position display
                        hideSetPositionDisplay();

                        setSelection = 0;
                        stopPos = progressBarActuator.Value;
                        motorButton.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.Start_button;
                        motorStartStop = true;



                    }




                }
                // Start Auto Move Motor
                else if (automove == false)
                {
                    // Disable end workout button
                    back_button.Enabled = false;

                    // auto move is enabled
                    automove = true;

                    
                    // Start timer 2
                    timer2.Enabled = true;
                    timer2.Start();

                    // Change GUI Graphic
                    back_button.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.End_Workout_disable;
                    motorButton.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.Stop_button;
                    this.Refresh();

                     
                }
                // Stop Motor
                else
                {

                    // Stop Timer 
                    timer1.Enabled = false;
                    timer2.Stop();
                    timer2.Enabled = false;
                    
                    // Stop Motor
                    if(motormoving == true)
                    {
                        xAxisEventObj.Stop();
                        xAxisAmp.HaltMove();
                    }
                        

                    back_button.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.End_Workout;
                    motorButton.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.Start_button;
                    this.Refresh();

                    back_button.Enabled = true;
                    automove = false;

                }


            }
            catch (Exception ex)
            {
                // Stop Motor
                if (motormoving == true)
                {
                    xAxisEventObj.Stop();
                    xAxisAmp.HaltMove();
                }

                
                automove = false;
                motormoving = false;
                back_button.Enabled = true;
                motorButton.Enabled = true;
                motorButton.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.Start_button;
                back_button.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.End_Workout;
                
                DisplayErrorPopup("Motor Comand Error", "Malfunction in action button: 1000");
            }


            motorButton.Enabled = true;
        }
        
        //
        // 0 - set start position display
        // 1 - set stop position display
        private void showSetPositionDisplay(int display)
        {

            positionDisplayLabel.Visible = true;
            
            incPosButton.Visible = true;
            decPosButton.Visible = true;
            positionLabel.Visible = true;
            label8.Visible = true;
            
            if (display == 0)
            {
                positionDisplayLabel.Text = "SET START POSITION";
            }
            else if (display == 1)
            {
                positionDisplayLabel.Text = "SET STOP POSITION";
            }

            positionLabel.Text = progressBarActuator.Value.ToString();
            motorButton.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.Init_button;
            motorStartStop = false;
        }

        private void hideSetPositionDisplay()
        {

            positionDisplayLabel.Visible = false;
            incPosButton.Visible = false;
            decPosButton.Visible = false;
            positionLabel.Visible = false;
            label8.Visible = false;
            
        }

        private void timerStartTick(object sender, EventArgs e)
        {
            sec++;
            total_time_sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
            }
            if (sec < 10)
            {
                time = min.ToString() + ":0" + sec.ToString();
            }
            else
            {
                time = min.ToString() + ":" + sec.ToString();
            }

            timer.Text = time;


            // update rep count
            REPSDisp.Text = totalReps.ToString();

            String b = buffer.Clone().ToString();
            if (b != null)
            {

                double voltage = Convert.ToDouble(b.ToString());
                //double weight = (-2.37 * voltage * voltage) + (69.02 * voltage) - 0.69;
                double weight = (-22.8 * voltage * voltage) + (145.28 * voltage) - 3.0314;

                if (weight < 0)
                {
                    weight = 0;
                }


                if (weight > max_weight)
                {
                    max_weight = weight;
                    updateMaxWeight(max_weight);
                }

                totalWeight += weight;
                avg_weight = totalWeight / total_time_sec;

                updateAvgWeight(avg_weight);

                updateRTWeight(weight);
                

                this.workout_livechart.Series["loadcelldata"].Points.AddXY(total_time_sec, (int)weight);
                this.workout_livechart.ChartAreas[0].CursorX.SetCursorPosition(total_time_sec);
                if (total_time_sec % 5 == 0)
                {
                    this.workout_livechart.Series["loadcelldata"].Points.ElementAt(total_time_sec).IsValueShownAsLabel = true;
                }
                if (total_time_sec > 19 && total_time_sec % 1 == 0)
                {
                    this.workout_livechart.ChartAreas[0].AxisX.ScaleView.Position = total_time_sec - 19;
                }

            }



        }


        void port_DataReceived(object s, SerialDataReceivedEventArgs e)
        {
            try
            {
                buffer = arduinoPort.ReadLine();

            }
            catch
            {

            }

        }

        private void createlivechart()
        {
            this.workout_livechart.Series[0].Points.Clear();
            this.workout_livechart.ChartAreas[0].AxisX.Minimum = 0;
            this.workout_livechart.ChartAreas[0].AxisY.Minimum = 0;
            this.workout_livechart.Series["loadcelldata"].Points.AddXY(0, 0);
        }

        /// <summary>
        /// Move Linear Actuator to zero position 
        /// </summary>
        private void setActuatorPositionZero()
        {
            try
            {
                // Move Actuator to set zero position
                moveMotor(10, ACCELERATION_DEFAULT, ZERO_POS_DEFAULT);
                
                xAxisAmp.WaitMoveDone(-1);

                // Actuator has been set to zero position
                xAxisAmp.ClearFaults();
                updateActuatorPositionBar();
            }
            catch
            {
                // Actuator has been set to zero position
                xAxisAmp.ClearFaults();
                updateActuatorPositionBar();

            }
            
        }

        private void speedPlusButton_Click(object sender, EventArgs e)
        {
            if (currSpeed < SPEED_LIMIT)
            {

                currSpeed += 1;
                setSpeed(currSpeed);

            }

        }

        private void speedMinusButton_Click(object sender, EventArgs e)
        {
            if (currSpeed > 1)
            {
                currSpeed -= 1;
                setSpeed(currSpeed);
            }
        }

        private void calibratePositionZero()
        {
            try
            {
                moveMotor(8, ACCELERATION_DEFAULT, -96);

                xAxisAmp.WaitMoveDone(-1);

                xAxisAmp.ClearFaults();                                     // clears fault code it creates
                xAxisAmp.PositionActual = 0;
                updateActuatorPositionBar();

            }catch(Exception ex)
            {
                xAxisAmp.ClearFaults();                                     // clears fault code it creates
                xAxisAmp.PositionActual = 0;
                updateActuatorPositionBar();
                //DisplayErrorPopup("Initialize motor error.", "Error in Set to Position Zero.");
            }
            

        }

        private void incPosButton_Click(object sender, EventArgs e)
        {
            incPosButton.Enabled = false;
            decPosButton.Enabled = false;

            

            if ((xAxisAmp.PositionActual/10) <= (END_POS_DEFAULT - MOVE_INCREMENT))
            {
                int currposition = progressBarActuator.Value;
                int difference = stopPos - currposition;


                // move start marker
                if (setSelection == 0 && (difference > 10))
                {
                    double move = xAxisAmp.PositionActual / 10;
                    move = move + MOVE_INCREMENT;

                    moveMotor(5, ACCELERATION_DEFAULT, (int)move);
                    xAxisAmp.WaitMoveDone(-1);

                    updateActuatorPositionBar();

                    Point point = new Point(startMarker.Location.X + 40, startMarker.Location.Y);
                    startMarker.Location = point;
                }
                // move stop marker
                else if (setSelection == 1)
                {
                    double move = xAxisAmp.PositionActual / 10;
                    move = move + MOVE_INCREMENT;

                    moveMotor(5, ACCELERATION_DEFAULT, (int)move);
                    xAxisAmp.WaitMoveDone(-1);

                    updateActuatorPositionBar();

                    Point point = new Point(stopMarker.Location.X + 40, stopMarker.Location.Y);
                    stopMarker.Location = point;
                    
                }

                int position = progressBarActuator.Value;
                positionLabel.Text = position.ToString();

            }
            incPosButton.Enabled = true;
            decPosButton.Enabled = true;
        }

        private void decPosButton_Click(object sender, EventArgs e)
        {
            incPosButton.Enabled = false;
            decPosButton.Enabled = false;

            
            
            if ((xAxisAmp.PositionActual / 10) >= (START_POS_DEFAULT + MOVE_INCREMENT))
            {
                int currposition = progressBarActuator.Value;
                int difference = currposition - startPos;

                // move start marker
                if (setSelection == 0)
                {
                    double move = xAxisAmp.PositionActual / 10;
                    move = move - MOVE_INCREMENT;
                    moveMotor(5, ACCELERATION_DEFAULT, (int)move);

                    xAxisAmp.WaitMoveDone(-1);

                    updateActuatorPositionBar();

                    Point point = new Point(startMarker.Location.X - 40, startMarker.Location.Y);
                    startMarker.Location = point;
                }
                // move stop marker
                else if (setSelection == 1 && (difference > 10))
                {
                    double move = xAxisAmp.PositionActual / 10;
                    move = move - MOVE_INCREMENT;
                    moveMotor(5, ACCELERATION_DEFAULT, (int)move);

                    xAxisAmp.WaitMoveDone(-1);

                    updateActuatorPositionBar();

                    Point point = new Point(stopMarker.Location.X - 40, stopMarker.Location.Y);
                    stopMarker.Location = point;

                }

                int position = progressBarActuator.Value;
                positionLabel.Text = position.ToString();
                
            }

            incPosButton.Enabled = true;
            decPosButton.Enabled = true;
        }
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            updateActuatorPositionBar();

            // check load cell for user force

            if (buffer != null)
            {
                //testLabel.Text = buffer.ToString();
                double voltage = Convert.ToDouble(buffer.ToString());
                double weight = (-22.8 * voltage * voltage) + (145.28 * voltage) - 3.0314;

                if (weight > WEIGHT_THRESHOLD && motormoving == false)
                {

                    // Auto move motor to start/stop Position
                    //xAxisAmp.ClearFaults();             // clear motor faults
                    AutoMoveMotor(direction);
                    xAxisEventObj.Start(true, -1);                              // start DONE movement listener

                    // Start Timer 
                    timer1.Enabled = true;
                    timer1.Start();

                    motormoving = true;
                }
                else if (weight < WEIGHT_THRESHOLD && motormoving == true)
                {
                    xAxisEventObj.Stop();
                    xAxisAmp.HaltMove();
                    timer1.Stop();
                    motormoving = false;
                }



            }
        }

        private void setStartStopPositions(int start_pos, int stop_pos)
        {
            startPos = start_pos;
            stopPos = stop_pos;
            motorStartStop = true;
        }

        private void setMarkers()
        {
            Point point = new Point(startMarker.Location.X, startMarker.Location.Y);
            stopMarker.Location = point;

            int movex = stopPos / MOVE_INCREMENT;
            movex = movex * 40;
            movex = stopMarker.Location.X + movex;
            point = new Point(movex, stopMarker.Location.Y);
            stopMarker.Location = point;

            movex = startPos / MOVE_INCREMENT;
            movex = movex * 40;
            movex = startMarker.Location.X + movex;
            point = new Point(movex, startMarker.Location.Y);
            startMarker.Location = point;
            

        }

        private void workout_screen_Load(object sender, EventArgs e)
        {

        }

        private void setStartPos()
        {
            startPos = Convert.ToInt32(positionLabel.Text.ToString());
        }

        private void setStopPos()
        {
            stopPos = Convert.ToInt32(positionLabel.Text.ToString());
        }

        private void saveStartStopPosDB()
        {

            /////////// DATABASE COMMAND GOES HERE /////////////////////
        }
    }
}
