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

namespace TeamMusclesAndMachine
{
    public partial class UserControl_MoveMotor : UserControl
    {


        //***************************************************
        //
        //  CANOpen Network
        //
        //***************************************************
        const int X_AXIS_CAN_ADDRESS = 1;
        canOpenObj canOpen;

        AmpObj xAxisAmp;
        ProfileSettingsObj ProfileSettings;
        HomeSettingsObj Home;

        // Create a delegate to close down the application in a thread safe way
        delegate void CloseApp();

        public UserControl_MoveMotor()
        {
            InitializeComponent();
        }
        



        private void MotorForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Initialize code here
                xAxisAmp = new AmpObj();

                //***************************************************
                //
                //  CANOpen Network
                //
                //***************************************************
                canOpen = new canOpenObj();
                //
                //**************************************************************************
                //* The next two lines of code are optional. If no bit rate is specified,
                //* then the default bit rate (1 Mbit per second) is used.  If no port name
                //* is specified, then CMO will use the first supported CAN card found and
                //* use channel 0 of that card.
                //**************************************************************************
                // Set the bit rate to 1 Mbit per second
                canOpen.BitRate = CML_BIT_RATES.BITRATE_1_Mbit_per_sec;
                // Indicate that channel 0 of a Copley CAN card should be used
                canOpen.PortName = "copley0";
                //***************************************************
                //* Initialize the CAN card and network
                //***************************************************
                canOpen.Initialize();
                //***************************************************
                //* Initialize the amplifier
                //***************************************************
                xAxisAmp.Initialize(canOpen, X_AXIS_CAN_ADDRESS);
                

                // Read velocity loop settings from the amp, use these as reasonble starting
                // points for the trajectory limits.
                VelocityTextBox.Text = Convert.ToString((xAxisAmp.VelocityLoopSettings.VelLoopMaxVel) / 10);
                AccelTextBox.Text = Convert.ToString((xAxisAmp.VelocityLoopSettings.VelLoopMaxAcc) / 10);
                DecelTextBox.Text = Convert.ToString((xAxisAmp.VelocityLoopSettings.VelLoopMaxDec) / 10);

                // Initialize home object with amplifier home settings 
                Home = xAxisAmp.HomeSettings;
                
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }


        private void AutoMoveButton_Click(object sender, EventArgs e)
        {
            try
            {

                AutoButton.Enabled = false;

                Home.HomeVelFast = (xAxisAmp.VelocityLoopSettings.VelLoopMaxVel) / 10;
                Home.HomeVelSlow = (xAxisAmp.VelocityLoopSettings.VelLoopMaxVel) / 15;
                Home.HomeAccel = xAxisAmp.VelocityLoopSettings.VelLoopMaxAcc / 10;
                Home.HomeMethod = CML_HOME_METHOD.CHOME_INDEX_POSITIVE;
                Home.HomeOffset = -1000;
                xAxisAmp.HomeSettings = Home;
                xAxisAmp.GoHome();
                xAxisAmp.WaitMoveDone(10000);

                motorMoveButton.Enabled = true;

                AutoButton.Enabled = true;
            }
            catch (Exception ex)
            {
                AutoButton.Enabled = true;
                DisplayError(ex);
            }
        }


        private void motorEnableButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (enableButton.Text == "Motor Disable")
                {
                    xAxisAmp.Disable();
                    enableButton.Text = "Motor Enable";
                }
                else
                {
                    xAxisAmp.Enable();
                    enableButton.Text = "Motor Disable";
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }


        private void motorMoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Double Distance;
                Distance = Convert.ToDouble(DistanceTextBox.Text);

                ProfileSettings = xAxisAmp.ProfileSettings; // read profile settings from amp

                //Set the profile type for move
                ProfileSettings.ProfileType = CML_PROFILE_TYPE.PROFILE_TRAP;

                //Set the profile trajectory values 
                ProfileSettings.ProfileAccel = Convert.ToDouble(AccelTextBox.Text);
                ProfileSettings.ProfileDecel = Convert.ToDouble(DecelTextBox.Text);
                ProfileSettings.ProfileVel = Convert.ToDouble(VelocityTextBox.Text);

                // Update the amplier's profile settigns
                xAxisAmp.ProfileSettings = ProfileSettings;

                // Execute the move
                xAxisAmp.MoveRel(Distance);
            }
            catch (Exception ex)
            {
                motorMoveButton.Enabled = true;
                AutoButton.Enabled = true;
                DisplayError(ex);
            }
        }


        private void motorStopMoveButton_Click(object sender, EventArgs e)
        {
            try
            {

                motorMoveButton.Enabled = false;
                AutoButton.Enabled = false;

                //set halt mode desired before halting the move
                xAxisAmp.HaltMode = CML_HALT_MODE.HALT_DECEL;
                // now halt the move
                xAxisAmp.HaltMove();

                motorMoveButton.Enabled = true;
                AutoButton.Enabled = true;
            }
            catch (Exception ex)
            {
                motorMoveButton.Enabled = true;
                AutoButton.Enabled = true;
                DisplayError(ex);
            }
        }

        private void motorFormClosing(object sender, FormClosingEventArgs e)
        {
            xAxisAmp.Disable();
        }

        public void DisplayError(Exception ex)
        {
            DialogResult errormsgbox = new DialogResult();
            MessageBox.Show("Error Message: " + ex.Message + "\n" + "Error Source: "
                + ex.Source, "CMO Error", MessageBoxButtons.RetryCancel);
            if (errormsgbox == DialogResult.Cancel)
            {
                // it is possible that this method was called from a thread other than the 
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
    
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
