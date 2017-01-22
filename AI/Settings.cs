using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace can_sat_image.AI
{
    public partial class Settings : Form
    {
        private Analyzer _eigenAnalyzer; 
        public Settings(Analyzer _analyzer)
        {
            _eigenAnalyzer = _analyzer;
            InitializeComponent();
        }

        public int Treshold;
        public int Iterations;
        public float Epsilon;


        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Treshold_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                val.Text = "Value: " + _treshold.Value + "";

                Treshold = _treshold.Value;
          
            }
            catch { }
        }

        private void _maxIteration_TextChanged(object sender, EventArgs e)
        {
            try
            {

                int.TryParse(_maxIteration.Text, out Iterations);
              
            }
            catch { }
        }

        private void _epsilon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _epsilon.Text = _epsilon.Text.Replace(".", ",");
                float.TryParse(_epsilon.Text, out Epsilon);
              
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _eigenAnalyzer.Update(this);
            MessageBox.Show("Applied!");
            this.Hide();
        }
    }
}
