using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMLCOMLib;
using System.Threading;

namespace TeamMusclesAndMachine
{
    public partial class UserControl1 : UserControl
    {
        //***************************************************
        //
        //  CANOpen Network
        //
        //***************************************************
        short X_AXIS_CAN_ADDRESS;
        canOpenObj canOpen;
        AmpObj xAxisAmp;
        ProfileSettingsObj ProfileSettings;

        bool motorConnect;
        bool motorEnabled;
        bool actuatorZeroPos;
        bool actuatorReset;
        bool automove;
        
        int distMotor;
        eventObj xAxisEventObj;


        private void xAxisEventObj_EventNotify(CML_AMP_EVENT match, bool hasError)
        {
            try
            {
                if (hasError)
                {
                    xAxisAmp.HaltMove();
                    DisplayErrorPopup("CMO Error", "Auto Move Error.");
                }

                if (match == CML_AMP_EVENT.AMPEVENT_MOVE_DONE)
                {
                    initLabel.BackColor = Color.Violet;
                }
                

                int Accel, Vel;
                Accel = Convert.ToInt32(accTextBox.Text);
                Vel = Convert.ToInt32(velTextBox.Text);

                distMotor = distMotor * (-1);

                moveMotor(Vel, Accel, distMotor);
                
            }
            catch (Exception ex)
            {
                DisplayErrorPopup("Auto Move Error", "Auto Move Error.");
            }
        }

        //***************************************************
        // Default Constructor
        //
        //***************************************************
        public UserControl1()
        {
            // Initilize variable to defaults states
            this.X_AXIS_CAN_ADDRESS = 1;            // DEFAULT can address set to 1
            this.motorConnect = false;
            this.motorEnabled = false;
            this.actuatorReset = false;
            this.actuatorZeroPos = false;           // ACTUATOR: Not at start (0) position 
            this.automove = false;


            


            InitializeComponent();
            
        }


        // Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();
        

        private void Motor_Connect()
        {

            try
            {
                short tempAddress;
                xAxisAmp = new AmpObj();

                //***************************************************
                //
                //  CANOpen Network
                //
                //***************************************************
                canOpen = new canOpenObj();
                // Set the bit rate to 1 Mbit per second
                canOpen.BitRate = CML_BIT_RATES.BITRATE_1_Mbit_per_sec;
                // Indicate that channel 0 of a Copley CAN card should be used
                canOpen.PortName = "copley0";

                //***************************************************
                //* Initialize the CAN card and network
                //***************************************************
                canOpen.Initialize();
                
                X_AXIS_CAN_ADDRESS = (short) getCANChannel();


                //***************************************************
                //* Initialize the Amplifier (Stepnet)
                //***************************************************
                xAxisAmp.Initialize(canOpen, X_AXIS_CAN_ADDRESS);
                //**************************************
                //* Clear Errors
                //**************************************
                xAxisAmp.ClearFaults();
                xAxisAmp.Disable();

                //***************************************************
                //* Create Event Handler for the Amplifier (Stepnet)
                //***************************************************
                xAxisEventObj = xAxisAmp.CreateEvent(CML_AMP_EVENT.AMPEVENT_MOVE_DONE,
                                            CML_EVENT_CONDITION.CML_EVENT_ANY);
                xAxisEventObj.EventNotify += new eventObj.EventHandler(xAxisEventObj_EventNotify);


            }
            catch (Exception ex)
            {
                DisplayErrorPopup("Linear Actuator Error", "Connection to Stepnet failed. Check that device is "+
                                                        "connected and CAN Channel selected is correct.");
            }
        }

        private short getCANChannel()
        {
            short temp;
            try
            {
                temp = (short)canChannelOption.Value;
                return temp;

            }
            catch (Exception ex)
            {
                return 1;
            }
            
        }

        private void EnableMotor()
        {
            try
            {
                if (motorEnabled)
                {
                    xAxisAmp.Disable();
                    enableStatusLabel.Text = "Motor Disable";
                    enableStatusLabel.BackColor = Color.Gray;
                    motorEnabled = false;
                }
                else
                {
                    
                    xAxisAmp.Enable();
                    enableStatusLabel.Text = "Motor Enable";
                    enableStatusLabel.BackColor = Color.Green;
                    motorEnabled = true;
                }
            }
            catch (Exception ex)
            {
                DisplayErrorPopup("Actuator Motor Error", "Connection error with linear actuator." +
                                                           " Reconnect to motor.");
            }

        }

        private void moveMotor(int velocity, int acceleration, int distance)
        {
            double vel, accel, dist;

            vel = Convert.ToDouble(velocity) * 1000;
            accel = Convert.ToDouble(acceleration) * 1000;
            dist = Convert.ToDouble(distance) * 1000;

            ProfileSettings = xAxisAmp.ProfileSettings; // read profile settings from amp

            //Set the profile type for move
            ProfileSettings.ProfileType = CML_PROFILE_TYPE.PROFILE_TRAP;

            //Set the profile trajectory values 
            ProfileSettings.ProfileAccel = accel;
            ProfileSettings.ProfileDecel = accel;
            ProfileSettings.ProfileVel = vel;

            // Update the amplier's profile settigns
            xAxisAmp.ProfileSettings = ProfileSettings;

            // Execute the move
            xAxisAmp.MoveRel(dist);


        }

        private void enableMotorButton_Click(object sender, EventArgs e)
        {
            motorEnabledButton.Enabled = false;
            EnableMotor();
            motorEnabledButton.Enabled = true;
        }

        private void moveStatusLabel_Click(object sender, EventArgs e)
        {

        }


        //*********************************************
        //
        //
        //*********************************************
        private void motorMoveButton_Click(object sender, EventArgs e)
        {
            try
            {

                moveStatusLabel.BackColor = Color.Green;
                moveStatusLabel.Text = "Motor Active";


                this.Refresh();
                System.Threading.Thread.Sleep(10);
                


                int Dist, Accel, Vel;
                Dist = Convert.ToInt32(distTextBox.Text);
                Accel = Convert.ToInt32(accTextBox.Text);
                Vel = Convert.ToInt32(velTextBox.Text);
                
                moveMotor(Vel, Accel, Dist);

               // xAxisAmp.WaitMoveDone(-1) ;
                //moveStatusLabel.BackColor = Color.Red;
                //moveStatusLabel.Text = "Motor Inactive";

            }
            catch (Exception ex)
            {
                moveStatusLabel.BackColor = Color.Gray;
                moveStatusLabel.Text = "Motor Stopped";
                DisplayErrorPopup("Motor Comand Error", "Malfunction with motor.");
            }

        }

        private void motorStopButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable buttons function while executing this function
                motorMoveButton.Enabled = false;
                motorAutoMove.Enabled = false;

                

                moveStatusLabel.BackColor = Color.Red;
                moveStatusLabel.Text = "Motor Stopped";

                if(automove == true)
                    xAxisEventObj.Stop();

                StopMotor();
                automove = false;

                motorMoveButton.Enabled = true;
                motorAutoMove.Enabled = true;
            }
            catch (Exception ex)
            {
                motorMoveButton.Enabled = true;
                motorAutoMove.Enabled = true;
                moveStatusLabel.BackColor = Color.Yellow;
                DisplayErrorPopup("Motor Comand Error", "Malfunction with motor movement.");
            }



        }

        private void StopMotor()
        {
            //set halt mode desired before halting the move
            xAxisAmp.HaltMode = CML_HALT_MODE.HALT_DECEL;
            // now halt the move
            xAxisAmp.HaltMove();
        }

        private void motorAutoMove_Click(object sender, EventArgs e)
        {
            try
            {
                motorAutoMove.Enabled = false;
                automove = true;
                
                moveStatusLabel.BackColor = Color.Green;
                moveStatusLabel.Text = "Motor Auto Move";
                this.Refresh();

                int Accel, Vel;
                distMotor = Convert.ToInt32(distTextBox.Text);
                Accel = Convert.ToInt32(accTextBox.Text);
                Vel = Convert.ToInt32(velTextBox.Text);

                // Start 1st movement
                moveMotor(Vel, Accel, distMotor);

                // Start event listener for when it finishes
                xAxisEventObj.Start(true, 50000);

                
            }
            catch(Exception ex)
            {
                automove = false;

                moveStatusLabel.BackColor = Color.Red;
                moveStatusLabel.Text = "Motor Stopped";

                ready_Label.BackColor = Color.Yellow;
                ready_Label.Text = "ERROR";

                motorAutoMove.Enabled = true;

                DisplayErrorPopup("Motor Comand Error", "Malfunction with motor movement.");
            }

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }



        public void DisplayError(Exception ex)
        {
            DialogResult errormsgbox = new DialogResult();
            MessageBox.Show("Error Message: " + ex.Message + "\n" + "Error Source: "
                + ex.Source, "CMO Error", MessageBoxButtons.RetryCancel);
            if (errormsgbox == DialogResult.Cancel)
            {
                // GUI thread - if this is the case we must use a delegate to close the application.
                //Dim d As New CloseApp(AddressOf ThreadSafeClose)
                CloseApp d = new CloseApp(ThreadSafeClose);
                this.Invoke(d);
            }
        }

        public void DisplayErrorPopup(String source, String message)
        {
            DialogResult errormsgbox = new DialogResult();
            MessageBox.Show("ERROR: " + message, source, MessageBoxButtons.OK,MessageBoxIcon.Error);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connectButton.Enabled = false;
            if (!motorConnect)
            {
                // tries to connect to motor
                Motor_Connect();
                motorConnect = true;
                connectButton.Text = "Motor Disconnect";
                motorConnectLabel.Text = "Device Connected";
                motorConnectLabel.BackColor = Color.Green;
            }
            else
            {
                if (motorEnabled == true)
                    EnableMotor();
                //canOpen.Close();
                motorConnect = false;
                connectButton.Text = "Motor Connect";
                motorConnectLabel.Text = "Device Disconnected";
                motorConnectLabel.BackColor = Color.Gray;
            }
            connectButton.Enabled = true;
        }

        private void motorStartButton_Click(object sender, EventArgs e)
        {

            try
            {
                // Start Motor
                if (automove ==  false)
                {
                    automove = true;

                    moveStatusLabel.BackColor = Color.Green;
                    moveStatusLabel.Text = "Motor Auto Move";
                    motorStartButton.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.Stop_button;
                    this.Refresh();

                    int Accel, Vel;
                    distMotor = Convert.ToInt32(distTextBox.Text);
                    Accel = Convert.ToInt32(accTextBox.Text);
                    Vel = Convert.ToInt32(velTextBox.Text);

                    // Start 1st movement
                    moveMotor(Vel, Accel, distMotor);

                    // Start event listener for when it finishes
                    xAxisEventObj.Start(true, 50000);
                }

                // Stop Motor
                else
                {
                    motorStartButton.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.Start_button;
                    xAxisEventObj.Stop();
                    automove = false;
                }

            }
            catch (Exception ex)
            {
                automove = false;
                xAxisEventObj.Stop();
                ready_Label.BackColor = Color.Yellow;
                motorStartButton.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.Start_button;
                ready_Label.Text = "ERROR: MOTOR";
                DisplayErrorPopup("Motor Comand Error", "Malfunction with motor.");
            }
        }

        private void velTextBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void distTextBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void velocityLabel_Click(object sender, EventArgs e)
        {

        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void speedMinusButton_Click(object sender, EventArgs e)
        {

        }
    }
}
