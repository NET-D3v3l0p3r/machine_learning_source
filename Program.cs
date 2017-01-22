using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu.Util;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using Emgu.CV.Features2D;
using Emgu.CV.GPU;
using Emgu.CV.CvEnum;
using System.Windows.Forms;

namespace can_sat_image
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CanSatImageProcessingGUI());
        }
    }
}
