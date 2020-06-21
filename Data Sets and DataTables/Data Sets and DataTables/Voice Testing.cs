using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace Data_Sets_and_DataTables
{
    public partial class Voice_Testing : Form
    {
        public Voice_Testing()
        {
            InitializeComponent();
        }

        SpeechSynthesizer sp = new SpeechSynthesizer();
        private void Voice_Testing_Load(object sender, EventArgs e)
        {
        }
        private void Speak_Click(object sender, EventArgs e)
        {

            sp.Volume = VolumeTrackBar.Value;
            sp.Rate = SpeedTrackBar.Value;
            if (MaleRadioButton.Checked)
            {
                sp.SelectVoiceByHints(VoiceGender.Male);
            }
            else if(FemaleRadioButton.Checked)
            {
                sp.SelectVoiceByHints(VoiceGender.Female);
            }
            sp.Speak(textBox.Text);
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            WEB_BROWSER browser = new WEB_BROWSER();
            browser.ShowDialog();
        }
    }
}
