using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using can_sat_image.AI;

namespace can_sat_image
{
    public partial class CanSatImageProcessingGUI : Form
    {
        public CanSatImageProcessingGUI()
        {
            InitializeComponent();
        }

        // STATISTICS

        private int counterTests = 0;
        private int counterSuccess = 0;

        Training training = new Training(327, 280, 15);
        Analyzer analyzer = new Analyzer(327, 280, 15);

        //TRAINING
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(training.GetTemporary(), new PointF(0, 0));
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseUpPanel1 || e.Button == MouseButtons.Right)
                return;

            training.AddRect(e.X, e.Y);
            panel1.Invalidate();
        }
        //TESTING
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(analyzer .GetTemporary(), new PointF(0, 0));
        }

        private void CanSatImageProcessingGUI_Load(object sender, EventArgs e)
        {
            analyzer.Training = training;
        }


        private bool mouseUpPanel1 = true;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (checkBox1.Checked)
                {
                    training.Save(textBox1.Text);
                    panel1.Invalidate();
                    label3.Text = "Saved...";
                    analyzer.Training = training;
                }
                training.Clear();
            }
            panel1.Invalidate();
            
            mouseUpPanel1 = false;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpPanel1 = true;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                training.Save(textBox1.Text);
                textBox1.Clear();
                panel1.Invalidate();
                label3.Text = "Saved...";
                analyzer.Training = training;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            training.Export();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Examples(training).Show();
        }

        private Settings settings;
        private void button2_Click(object sender, EventArgs e)
        {
            if (settings == null)
                settings = new Settings(analyzer);

            settings.Show();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseUpPanel2 || e.Button == MouseButtons.Right)
                return;
            analyzer.AddRect(e.X, e.Y);
            panel2.Invalidate();
            label1.Text = "Result: " + Examples.GetLetter(analyzer.Check());
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseUpPanel2 = false;
            if (e.Button == MouseButtons.Right)
            {
                if (label1.Text.Split(' ')[1].Equals(textBox2.Text))
                    counterSuccess++;
                counterTests++;

                _testSize.Text = "Tests: " + counterTests + "";
                _sucessSize.Text = "Succeed:" + counterSuccess + "";
                _percents.Text = (((double)counterSuccess / (double)counterTests)  * 10 * 10 )+ "%";

                analyzer.Clear();
            }
            panel2.Invalidate();
        }

        private bool mouseUpPanel2 = true;
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpPanel2 = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            counterSuccess = counterTests = 0;
            _testSize.Text = counterTests + "";
            _sucessSize.Text = counterSuccess + "";
            _percents.Text = "0%";
        }
    }
}
