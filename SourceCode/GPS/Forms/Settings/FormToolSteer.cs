using System;
using System.Drawing;
using System.Windows.Forms; 

namespace AgOpenGPS
{
    public partial class FormToolSteer : Form
    {

        private readonly FormGPS mf = null;

        private bool toSend = false;
        private int windowSizeState = 0;

        //Form stuff
        public FormToolSteer(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();

            nudToolAntennaHeight.Controls[0].Enabled = false;
            nudToolAntennaOffset.Controls[0].Enabled = false;
        }

        private void FormSteer_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.setGPS_isGPSTool
                && !Properties.Settings.Default.setGPS_isGPSToolOnly)
            {
                cboxGPSNormal.Checked = true;
                cboxGPSToolOnOff.Checked = false;
                cboxGPSToolOnlyOnOff.Checked = false;
            }
            else
            {
                cboxGPSNormal.Checked = false;
            }

            cboxGPSToolOnOff.Checked = Properties.Settings.Default.setGPS_isGPSTool;
            cboxGPSToolOnlyOnOff.Checked = Properties.Settings.Default.setGPS_isGPSToolOnly;

            hsbarTool_P.Value = Properties.Vehicle.Default.setTool_P;
            hsbarTool_I.Value = Properties.Vehicle.Default.setTool_I;
            hsbarTool_MinPWM.Value = Properties.Vehicle.Default.setTool_MinPWM;
            hsbarTool_LowPWM.Value = Properties.Vehicle.Default.setTool_LowPWM;
            hsbarTool_HighPWM.Value = Properties.Vehicle.Default.setTool_HighPWM;
            hsbarTool_Counts.Value = Properties.Vehicle.Default.setTool_Counts;
            hsbarTool_Offset.Value = Properties.Vehicle.Default.setTool_Offset;

            lblTool_P.Text = hsbarTool_P.Value.ToString();
            lblTool_I.Text = hsbarTool_I.Value.ToString();
            lblTool_MinPWM.Text = hsbarTool_MinPWM.Value.ToString();
            lblTool_LowPWM.Text = hsbarTool_LowPWM.Value.ToString();
            lblTool_HighPWM.Text = hsbarTool_HighPWM.Value.ToString();
            lblTool_Counts.Text = hsbarTool_Counts.Value.ToString();
            lblTool_Offset.Text = (hsbarTool_Offset.Value - 127).ToString();

            pboxSendToolSteer.Visible = false;

            if (cboxGPSToolOnlyOnOff.Checked) btnConvertToToolOnly.Visible = true;
            else btnConvertToToolOnly.Visible = false;

            nudToolAntennaHeight.Value = (int)(Properties.Vehicle.Default.setTool_antennaHeight * mf.m2InchOrCm);

            nudToolAntennaOffset.Value = (int)(Properties.Vehicle.Default.setTool_antennaOffset * mf.m2InchOrCm);
            
            //make sure free drive is off
            btnFreeDrive.Image = Properties.Resources.SteerDriveOff;
            mf.vehicle.ast.isInFreeToolDriveMode = false;
            btnSteerAngleDown.Enabled = false;
            btnSteerAngleUp.Enabled = false;
            //hSBarFreeDrive.Value = 0;
            mf.vehicle.ast.driveFreeToolDistance = 0;
        }

        private void FormSteer_FormClosing(object sender, FormClosingEventArgs e)
        {
            mf.vehicle.ast.isInFreeToolDriveMode = false;
            mf.vehicle.ast.driveFreeToolDistance = 0;

            mf.pn.isGPSTool = cboxGPSToolOnOff.Checked;
            Properties.Settings.Default.setGPS_isGPSTool = mf.pn.isGPSTool;
            mf.pn.isGPSToolOnly = cboxGPSToolOnlyOnOff.Checked;
            Properties.Settings.Default.setGPS_isGPSToolOnly = mf.pn.isGPSToolOnly;

            Properties.Settings.Default.Save();
            Properties.Vehicle.Default.Save();

            //save current vehicle
            SettingsIO.ExportAll(mf.vehiclesDirectory + mf.vehicleFileName + ".XML");
        }

        private void hsbarTool_Counts_ValueChanged(object sender, EventArgs e)
        {
            pboxSendToolSteer.Visible = true;
            lblTool_Counts.Text = hsbarTool_Counts.Value.ToString();
        }

        private void hsbarTool_P_ValueChanged(object sender, EventArgs e)
        {
            pboxSendToolSteer.Visible = true;
            lblTool_P.Text = hsbarTool_P.Value.ToString();
        }

        private void hsbarTool_I_ValueChanged(object sender, EventArgs e)
        {
            pboxSendToolSteer.Visible = true;
            lblTool_I.Text = hsbarTool_I.Value.ToString();
        }

        private void hsbarTool_MinPWM_ValueChanged(object sender, EventArgs e)
        {
            pboxSendToolSteer.Visible = true;
            lblTool_MinPWM.Text = hsbarTool_MinPWM.Value.ToString();
        }

        private void hsbarTool_LowPWM_ValueChanged(object sender, EventArgs e)
        {
            pboxSendToolSteer.Visible = true;
            lblTool_LowPWM.Text = hsbarTool_LowPWM.Value.ToString();
        }

        private void hsbarTool_HighPWM_ValueChanged(object sender, EventArgs e)
        {
            pboxSendToolSteer.Visible = true;
            lblTool_HighPWM.Text = hsbarTool_HighPWM.Value.ToString();
        }

        private void hsbarTool_Offset_ValueChanged(object sender, EventArgs e)
        {
            pboxSendToolSteer.Visible = true;
            lblTool_Offset.Text = (hsbarTool_Offset.Value - 127).ToString();
        }

        private void cboxGPSToolOnOff_Click(object sender, EventArgs e)
        {
            if (cboxGPSToolOnOff.Checked) return;
            else cboxGPSToolOnOff.Checked = true;
            if (cboxGPSToolOnlyOnOff.Checked) cboxGPSToolOnlyOnOff.Checked = false;
            if (cboxGPSNormal.Checked) cboxGPSNormal.Checked = false;
            if (cboxGPSToolOnlyOnOff.Checked) btnConvertToToolOnly.Visible = true;
            else btnConvertToToolOnly.Visible = false;

        }
        
        private void cboxGPSToolOnlyOnOff_Click(object sender, EventArgs e)
        {
            if (cboxGPSToolOnlyOnOff.Checked) return;
            else cboxGPSToolOnlyOnOff.Checked = true;
            if (cboxGPSToolOnOff.Checked) cboxGPSToolOnOff.Checked = false;
            if (cboxGPSNormal.Checked) cboxGPSNormal.Checked = false;
            if (cboxGPSToolOnlyOnOff.Checked) btnConvertToToolOnly.Visible = true;
            else btnConvertToToolOnly.Visible = false;
        }

        private void cboxGPSNormal_Click(object sender, EventArgs e)
        {
            if (cboxGPSNormal.Checked) return;
            else cboxGPSNormal.Checked = true;
            if (cboxGPSToolOnlyOnOff.Checked) cboxGPSToolOnlyOnOff.Checked = false;
            if (cboxGPSToolOnOff.Checked) cboxGPSToolOnOff.Checked = false;
            if (cboxGPSToolOnlyOnOff.Checked) btnConvertToToolOnly.Visible = true;
            else btnConvertToToolOnly.Visible = false;
        }

        private void btnConvertToToolOnly_Click(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Are you sure you want to change settings to Tool Only?",
                "Tool Only Settings",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result3 == DialogResult.Yes)
            {
                //make it see thru
                Properties.Settings.Default.setDisplay_vehicleOpacity = 23;
                mf.vehicleOpacity = 0.23;
                mf.vehicleOpacityByte = 60;

                //antenna slightly ahead of pivot at minimum distance
                mf.vehicle.antennaPivot = Properties.Vehicle.Default.setVehicle_antennaPivot = 0.1;

                //image to triangle
                mf.isVehicleImage = false;
                Properties.Settings.Default.setDisplay_isVehicleImage = false;

                //front hitch
                mf.tool.isToolRearFixed = Properties.Vehicle.Default.setTool_isToolRearFixed = false;
                mf.tool.isToolTrailing = Properties.Vehicle.Default.setTool_isToolTrailing = false;
                mf.tool.isToolTBT = Properties.Vehicle.Default.setTool_isToolTBT = false;
                mf.tool.isToolFrontFixed = Properties.Vehicle.Default.setTool_isToolFront = true;

                //hitch slightly forward to min length
                Properties.Vehicle.Default.setVehicle_hitchLength = mf.tool.hitchLength = 0.1;
            }
        }

        private void nudToolAntennaHeight_Click(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender, this))
            {
                Properties.Vehicle.Default.setTool_antennaHeight = (double)nudToolAntennaHeight.Value * mf.inchOrCm2m;
                mf.pn.toolAntennaHeight = Properties.Vehicle.Default.setTool_antennaHeight;
            }
        }
        
        private void nudToolAntennaOffset_Click(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender, this))
            {
                Properties.Vehicle.Default.setTool_antennaOffset = (double)nudToolAntennaOffset.Value * mf.inchOrCm2m;
                mf.pn.toolAntennaOffset = Properties.Vehicle.Default.setTool_antennaOffset;
            }
        }

        private void expandWindow_Click(object sender, EventArgs e)
        {
            if (windowSizeState++ > 0) windowSizeState = 0;
            if (windowSizeState == 1) this.Size = new System.Drawing.Size(381,663);
            else if (windowSizeState == 0) this.Size = new System.Drawing.Size(381, 545);

        }

        private void btnSendToolSteer_Click(object sender, EventArgs e)
        {
            Properties.Vehicle.Default.setTool_P = (byte)(hsbarTool_P.Value);
            Properties.Vehicle.Default.setTool_I = (byte)(hsbarTool_I.Value);
            Properties.Vehicle.Default.setTool_MinPWM = (byte)(hsbarTool_MinPWM.Value);
            Properties.Vehicle.Default.setTool_LowPWM = (byte)(hsbarTool_LowPWM.Value);
            Properties.Vehicle.Default.setTool_HighPWM = (byte)(hsbarTool_HighPWM.Value);
            Properties.Vehicle.Default.setTool_Counts = (byte)(hsbarTool_Counts.Value);
            Properties.Vehicle.Default.setTool_Offset = (byte)(hsbarTool_Offset.Value);

            mf.p_233.pgn[mf.p_233.P] = (byte)(hsbarTool_P.Value);
            mf.p_233.pgn[mf.p_233.I] = (byte)(hsbarTool_I.Value);
            mf.p_233.pgn[mf.p_233.minPWM] = (byte)(hsbarTool_MinPWM.Value);
            mf.p_233.pgn[mf.p_233.lowPWM] = (byte)(hsbarTool_LowPWM.Value);
            mf.p_233.pgn[mf.p_233.highPWM] = (byte)(hsbarTool_HighPWM.Value);
            mf.p_233.pgn[mf.p_233.counts] = (byte)(hsbarTool_Counts.Value);
            mf.p_233.pgn[mf.p_233.offset] = (byte)(hsbarTool_Offset.Value);

            mf.SendPgnToLoop(mf.p_233.pgn);
            pboxSendToolSteer.Visible = false;
        }


        #region Free Drive
        private void btnFreeDrive_Click(object sender, EventArgs e)
        {
            if (mf.vehicle.ast.isInFreeToolDriveMode)
            {
                //turn OFF free drive mode
                btnFreeDrive.Image = Properties.Resources.SteerDriveOff;
                btnFreeDrive.BackColor = Color.FromArgb(50, 50, 70);
                mf.vehicle.ast.isInFreeToolDriveMode = false;
                btnSteerAngleDown.Enabled = false;
                btnSteerAngleUp.Enabled = false;
                //hSBarFreeDrive.Value = 0;
                mf.vehicle.ast.driveFreeToolDistance = 0;
            }
            else
            {
                //turn ON free drive mode
                btnFreeDrive.Image = Properties.Resources.SteerDriveOn;
                btnFreeDrive.BackColor = Color.LightGreen;
                mf.vehicle.ast.isInFreeToolDriveMode = true;
                btnSteerAngleDown.Enabled = true;
                btnSteerAngleUp.Enabled = true;
                //hSBarFreeDrive.Value = 0;
                mf.vehicle.ast.driveFreeToolDistance = 0;
                lblSteerAngle.Text = "0";
            }
        }

        private void btnSteerAngleUp_MouseDown(object sender, MouseEventArgs e)
        {
            mf.vehicle.ast.driveFreeToolDistance++;
            if (mf.vehicle.ast.driveFreeToolDistance > 100) mf.vehicle.ast.driveFreeToolDistance = 100;
        }

        private void btnSteerAngleDown_MouseDown(object sender, MouseEventArgs e)
        {
            mf.vehicle.ast.driveFreeToolDistance--;
            if (mf.vehicle.ast.driveFreeToolDistance < -100) mf.vehicle.ast.driveFreeToolDistance = -100;
        }
        #endregion

        #region Help

        private void btnFreeDrive_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show(gStr.h_btnFreeDrive, gStr.gsHelp);
        }

        private void btnSteerAngleDown_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show(gStr.h_btnSteerAngleDown, gStr.gsHelp);
        }

        private void btnSteerAngleUp_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show(gStr.h_btnSteerAngleUp, gStr.gsHelp);
        }


        private void pboxSendSteer_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show(gStr.hc_pboxSendSteer, gStr.gsHelp);
        }

        #endregion

    }
}
