using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using svr2010;

namespace WWETest
{

    /// <summary>
    /// You will likely have a few errors starting off. Be sure you right click and re-add the correct .dll to the project!
    /// In the YouTube video, the .dll is called WWESmackdown.dll, but on my github it is called svr2010.dll
    /// Don't hesitate to reach out on the discord!
    /// </summary>
    public partial class Form1 : Form
    {
        public Wrestler Wrestler;
        private string fname;
        public Form1()
        {
            InitializeComponent();
        }

        private void openSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "(*.DAT)|*.DAT";
            if (o.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fname = o.FileName;
                    fileLoad.Text = $"{o.SafeFileName} - Loaded succsessfully";
                    strengthValue.Enabled = true;
                    submissionValue.Enabled = true;
                    speedValue.Enabled = true;
                    techValue.Enabled = true;
                    durValue.Enabled = true;
                    charValue.Enabled = true;
                    stamValue.Enabled = true;
                    hardValue.Enabled = true;
                    comboBox1.Enabled = true;
                    comboBox1.SelectedIndex = 0;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message);}
            }
        }


        private void StatChange(object sender, EventArgs e)
        {
            NumericUpDown NewVal = sender as NumericUpDown;
            switch (NewVal.Name)
            {
                case "strengthValue": Wrestler.Strength = (byte)NewVal.Value; break;
                case "submissionValue": Wrestler.Submission = (byte)NewVal.Value; break;
                case "speedValue": Wrestler.Speed = (byte)NewVal.Value; break;
                case "techValue": Wrestler.Technique = (byte)NewVal.Value; break;
                case "durValue": Wrestler.Durability = (byte)NewVal.Value; break;
                case "charValue": Wrestler.Charisma = (byte)NewVal.Value; break;
                case "stamValue": Wrestler.Stamina = (byte)NewVal.Value; break;
                case "hardValue": Wrestler.Hardcore = (byte)NewVal.Value; break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            uint Base = 0x0A14;
            Base = (uint)(Base + comboBox1.SelectedIndex * 0x0104);
            Wrestler = new Wrestler(fname, Base);
            strengthValue.Value = Wrestler.Strength;
            submissionValue.Value = Wrestler.Submission;
            speedValue.Value = Wrestler.Speed;
            techValue.Value = Wrestler.Technique;
            durValue.Value = Wrestler.Durability;
            charValue.Value = Wrestler.Charisma;
            stamValue.Value = Wrestler.Stamina;
            hardValue.Value = Wrestler.Hardcore;
        }
    }
}
