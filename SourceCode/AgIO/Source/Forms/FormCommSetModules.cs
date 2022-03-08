using System;
using System.Windows.Forms;

namespace AgIO
{
    public partial class FormCommSetModules : Form
    {
        //class variables
        private readonly FormLoop mf = null;

        //constructor
        public FormCommSetModules(Form callingForm)
        {
            //get copy of the calling main form
            mf = callingForm as FormLoop;
            InitializeComponent();
        }

        private void FormCommSet_Load(object sender, EventArgs e)
        {
            if (mf.spIMU.IsOpen)
            {
                cboxIMU.Enabled = false;
                btnCloseIMU.Enabled = true;
                btnOpenIMU.Enabled = false;
            }
            else
            {
                cboxIMU.Enabled = true;
                btnCloseIMU.Enabled = false;
                btnOpenIMU.Enabled = true;
            }


            //load the port box with valid port names
            cboxIMU.Items.Clear();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cboxIMU.Items.Add(s);
            }

            lblCurrentIMU.Text = mf.spIMU.PortName;

            if (mf.spModule1.IsOpen)
            {
                cboxModule1Port.Enabled = false;
                btnCloseSerialModule1.Enabled = true;
                btnOpenSerialModule1.Enabled = false;
            }
            else
            {
                cboxModule1Port.Enabled = true;
                btnCloseSerialModule1.Enabled = false;
                btnOpenSerialModule1.Enabled = true;
            }

            //check if AutoSteer port is open or closed and set buttons accordingly
            if (mf.spModule2.IsOpen)
            {
                cboxModule2Port.Enabled = false;
                btnCloseSerialModule2.Enabled = true;
                btnOpenSerialModule2.Enabled = false;
            }
            else
            {
                cboxModule2Port.Enabled = true;
                btnCloseSerialModule2.Enabled = false;
                btnOpenSerialModule2.Enabled = true;
            }

            if (mf.spModule3.IsOpen)
            {
                cboxModule3Port.Enabled = false;
                btnCloseSerialModule3.Enabled = true;
                btnOpenSerialModule3.Enabled = false;
            }
            else
            {
                cboxModule3Port.Enabled = true;
                btnCloseSerialModule3.Enabled = false;
                btnOpenSerialModule3.Enabled = true;
            }

            //load the port box with valid port names
            cboxModule1Port.Items.Clear();
            cboxModule2Port.Items.Clear();
            cboxModule3Port.Items.Clear();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cboxModule1Port.Items.Add(s);
                cboxModule2Port.Items.Add(s);
                cboxModule3Port.Items.Add(s);
            }

            lblCurrentModule1Port.Text = mf.spModule1.PortName;
            lblCurrentModule2Port.Text = mf.spModule2.PortName;
            lblCurrentModule3Port.Text = mf.spModule3.PortName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //GPS phrase
            lblSteer.Text = mf.spModule1.PortName;
            lblGPS.Text = mf.spGPS.PortName;
            lblGPS2.Text = mf.spGPS2.PortName;
            lblIMU.Text = mf.spIMU.PortName;
            lblMachine.Text = mf.spModule2.PortName;

            lblFromGPS.Text = mf.traffic.cntrGPSIn == 0 ? "--" : (mf.traffic.cntrGPSIn).ToString();
            lblFromGPS2.Text = mf.traffic.cntrGPS2In == 0 ? "--" : (mf.traffic.cntrGPS2In).ToString();

            lblFromModule1.Text = mf.traffic.cntrModule1In == 0 ? "--" : (mf.traffic.cntrModule1In).ToString();

            lblFromModule2.Text = mf.traffic.cntrModule2In == 0 ? "--" : (mf.traffic.cntrModule2In).ToString();

            lblFromMU.Text = mf.traffic.cntrIMUIn == 0 ? "--" : (mf.traffic.cntrIMUIn).ToString();

        }

        private void btnSerialOK_Click(object sender, EventArgs e)
        {
            //save
            //DialogResult = DialogResult.OK;
            Close();
        }

        private void btnRescan_Click(object sender, EventArgs e)
        {
            cboxPort.Items.Clear();
            cboxRtcmPort.Items.Clear();
            cboxPort2.Items.Clear();
            cboxIMU.Items.Clear();
            cboxModule1Port.Items.Clear();
            cboxModule2Port.Items.Clear();
            cboxModule3Port.Items.Clear();

            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cboxPort.Items.Add(s);
                cboxPort2.Items.Add(s);
                cboxIMU.Items.Add(s);
                cboxRtcmPort.Items.Add(s);
                cboxModule1Port.Items.Add(s);
                cboxModule2Port.Items.Add(s);
                cboxModule3Port.Items.Add(s);
            }
        }

        private void btnOpenIMU_Click(object sender, EventArgs e)
        {
            mf.OpenIMUPort();
            if (mf.spIMU.IsOpen)
            {
                cboxIMU.Enabled = false;
                btnCloseIMU.Enabled = true;
                btnOpenIMU.Enabled = false;
                lblCurrentIMU.Text = mf.spIMU.PortName;
            }
            else
            {
                cboxIMU.Enabled = true;
                btnCloseIMU.Enabled = false;
                btnOpenIMU.Enabled = true;
            }
        }

        private void btnCloseIMU_Click(object sender, EventArgs e)
        {
            mf.CloseIMUPort();
            if (mf.spIMU.IsOpen)
            {
                cboxIMU.Enabled = false;
                btnCloseIMU.Enabled = true;
                btnOpenIMU.Enabled = false;
            }
            else
            {
                cboxIMU.Enabled = true;
                btnCloseIMU.Enabled = false;
                btnOpenIMU.Enabled = true;
            }
        }

        private void cboxIMU_SelectedIndexChanged(object sender, EventArgs e)
        {
            mf.spIMU.PortName = cboxIMU.Text;
            FormLoop.portNameIMU = cboxIMU.Text;
            lblCurrentIMU.Text = cboxIMU.Text;
        }

        private void btnOpenSerialModule1_Click(object sender, EventArgs e)
        {
            mf.OpenModule1Port();
            if (mf.spModule1.IsOpen)
            {
                cboxModule1Port.Enabled = false;
                btnCloseSerialModule1.Enabled = true;
                btnOpenSerialModule1.Enabled = false;
                lblCurrentModule1Port.Text = mf.spModule1.PortName;
            }
            else
            {
                cboxModule1Port.Enabled = true;
                btnCloseSerialModule1.Enabled = false;
                btnOpenSerialModule1.Enabled = true;
            }
        }

        private void btnCloseSerialModule1_Click(object sender, EventArgs e)
        {
            mf.CloseModule1Port();
            if (mf.spModule1.IsOpen)
            {
                cboxModule1Port.Enabled = false;
                btnCloseSerialModule1.Enabled = true;
                btnOpenSerialModule1.Enabled = false;
            }
            else
            {
                cboxModule1Port.Enabled = true;
                btnCloseSerialModule1.Enabled = false;
                btnOpenSerialModule1.Enabled = true;
            }
        }

        private void cboxModule1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mf.spModule1.PortName = cboxModule1Port.Text;
            FormLoop.portNameModule1 = cboxModule1Port.Text;
            lblCurrentModule1Port.Text = cboxModule1Port.Text;
        }

        private void cboxModule2Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            mf.spModule2.PortName = cboxModule2Port.Text;
            FormLoop.portNameModule2 = cboxModule2Port.Text;
            lblCurrentModule2Port.Text = cboxModule2Port.Text;
        }

        private void btnOpenSerialModule2_Click(object sender, EventArgs e)
        {
            mf.OpenModule2Port();
            if (mf.spModule2.IsOpen)
            {
                cboxModule2Port.Enabled = false;
                btnCloseSerialModule2.Enabled = true;
                btnOpenSerialModule2.Enabled = false;
                lblCurrentModule2Port.Text = mf.spModule2.PortName;
            }
            else
            {
                cboxModule2Port.Enabled = true;
                btnCloseSerialModule2.Enabled = false;
                btnOpenSerialModule2.Enabled = true;
            }
        }

        private void btnCloseSerialModule2_Click(object sender, EventArgs e)
        {
            mf.CloseModule2Port();
            if (mf.spModule2.IsOpen)
            {
                cboxModule2Port.Enabled = false;
                btnCloseSerialModule2.Enabled = true;
                btnOpenSerialModule2.Enabled = false;
            }
            else
            {
                cboxModule2Port.Enabled = true;
                btnCloseSerialModule2.Enabled = false;
                btnOpenSerialModule2.Enabled = true;
            }
        }

        private void cboxModule3Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            mf.spModule3.PortName = cboxModule3Port.Text;
            FormLoop.portNameModule3 = cboxModule3Port.Text;
            lblCurrentModule3Port.Text = cboxModule3Port.Text;
        }

        private void btnOpenSerialModule3_Click(object sender, EventArgs e)
        {
            mf.OpenModule3Port();
            if (mf.spModule3.IsOpen)
            {
                cboxModule3Port.Enabled = false;
                btnCloseSerialModule3.Enabled = true;
                btnOpenSerialModule3.Enabled = false;
                lblCurrentModule3Port.Text = mf.spModule3.PortName;
            }
            else
            {
                cboxModule3Port.Enabled = true;
                btnCloseSerialModule3.Enabled = false;
                btnOpenSerialModule3.Enabled = true;
            }
        }

        private void btnCloseSerialModule3_Click(object sender, EventArgs e)
        {
            mf.CloseModule3Port();
            if (mf.spModule3.IsOpen)
            {
                cboxModule3Port.Enabled = false;
                btnCloseSerialModule3.Enabled = true;
                btnOpenSerialModule3.Enabled = false;
            }
            else
            {
                cboxModule3Port.Enabled = true;
                btnCloseSerialModule3.Enabled = false;
                btnOpenSerialModule3.Enabled = true;
            }
        }

        private void btnOpenSerial_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseSerial_Click(object sender, EventArgs e)
        {

        }

        private void cboxBaud_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cboxPort_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnOpenGPS2_Click(object sender, EventArgs e)
        {

        }

        private void cboxRtcmBaud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCloseGPS2_Click(object sender, EventArgs e)
        {

        }

        private void cboxRtcmPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenRTCM_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseRTCM_Click(object sender, EventArgs e)
        {

        }

        private void cboxBaud2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxPort2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } //class
} //namespace
