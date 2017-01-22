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
    public partial class Examples : Form
    {
        private Training training;
        public Examples(Training data)
        {
            training = data;
            InitializeComponent();
        }

        private void Examples_Load(object sender, EventArgs e)
        {
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
 

            int y = 0;
            for (int i = 0; i < training.Labels.Count; i++)
            {

                PictureBox pb = new PictureBox();
                pb.Image = new Bitmap(training.Images[i]);
                pb.BackColor = Color.Black;

                Label lb = new Label();
                lb.Text = "Letter: " + GetLetter(training.Labels[i]);
                lb.Font = new Font("Arial", 13);
                lb.Location = new Point(150, y + 10);
                panel1.Controls.Add(lb);

                pb.Size = new Size(50, 50);
                pb.Location = new Point(0, y);
                pb.Visible = true;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Name = i + "";

                panel1.Controls.Add(pb);

                y += 50;


            }
        }

        public static string GetLetter(string letter)
        {
            string result = "";
            char[] chars = letter.ToCharArray();
            
            for (int i = 0; i < chars.Length; i++)
            {
                result += char.IsLetter(chars[i]) ? chars[i] + "" : "";
            }

            return result; 
        }
    }
}
