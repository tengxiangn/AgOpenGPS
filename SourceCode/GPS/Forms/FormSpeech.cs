using System;
using System.Globalization;
using System.IO;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormSpeech : Form
    {
        //class variables
        private readonly FormGPS mf = null;

        public FormSpeech(Form callingForm)
        {
            //get copy of the calling main form
            mf = callingForm as FormGPS;

            InitializeComponent();

            this.Text = gStr.gsStartNewField;
        }

        private void nudConfidenceLevel_Click(object sender, EventArgs e)
        {
            mf.KeypadToNUD((NumericUpDown)sender, this);
            Properties.Settings.Default.setSpeech_confidence = (float)nudConfidenceLevel.Value;
            Properties.Settings.Default.Save();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            mf.Sarah.SpeakAsync("What the hell are you doing, I needed those.");
        }

        private void btnSpeech_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.setSpeech_isOn)
            {
                mf.SpeechOnOff(false);
                mf.recEngine.SpeechRecognized -= recEngine_SpeechRecognizedForm;
                btnSpeech.Text = "Off";
            }
            else
            {
                mf.SpeechOnOff(true);
                mf.recEngine.SpeechRecognized += recEngine_SpeechRecognizedForm;
                btnSpeech.Text = "On";
            }

            Properties.Settings.Default.setSpeech_isOn = !Properties.Settings.Default.setSpeech_isOn;
            Properties.Settings.Default.Save();
        }

        private void FormSpeech_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.setSpeech_isOn)
            {
                mf.recEngine.SpeechRecognized += recEngine_SpeechRecognizedForm;
                btnSpeech.Text = "On";
            }
            else
            {
                btnSpeech.Text = "Off";
            }

            nudConfidenceLevel.Value = (decimal)Properties.Settings.Default.setSpeech_confidence;
        }
        public void recEngine_SpeechRecognizedForm(object sender, SpeechRecognizedEventArgs e)
        {
            textBox2.AppendText(e.Result.Confidence.ToString("N3") + " - " + e.Result.Text + "\r\n");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            mf.recEngine.SpeechRecognized -= recEngine_SpeechRecognizedForm;
            Close();
        }
    }
}