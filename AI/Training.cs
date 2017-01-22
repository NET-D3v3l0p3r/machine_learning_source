using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Emgu.Util;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using System.Drawing;
using System.Diagnostics;
using Emgu.CV.Features2D;
using Emgu.CV.GPU;
using Emgu.CV.CvEnum;
namespace can_sat_image.AI
{
    public class Training
    {

        public int ImageWidth { get; private set; }
        public int ImageHeight { get; private set; }

        public int PixelSize { get; private set; }

        public List<string> Labels = new List<string>();
        public List<Bitmap> Images = new List<Bitmap>();

        private Graphics _device;
        private Bitmap _currentImage;
        private int _count = 0;

        public Training(int w, int h, int pixel)
        {

            ImageWidth = w;
            ImageHeight = h;

            PixelSize = pixel;

            Import();
        }

        public void AddRect(int x, int y)
        {
            if (_currentImage == null)
            {
                _currentImage = new Bitmap(ImageWidth, ImageHeight);
                _device = Graphics.FromImage(_currentImage);
            }

            _device.FillRectangle(Brushes.White, new RectangleF(x, y, PixelSize, PixelSize));

        }

        public void Clear()
        {
            if (_currentImage != null)
                _currentImage.Dispose();
            if (_device != null)
                _device.Dispose();

            _device = null;
            _currentImage = null;
        }

        public Bitmap GetTemporary()
        {
            if (_currentImage == null) return new Bitmap(1, 1);
            return _currentImage;
        }

        public void Save(string label)
        {
            if (!Labels.Contains(label))
                Labels.Add(label);
            else
                Labels.Add(label + _count++);

            if (_currentImage != null)


                Images.Add(new Bitmap(_currentImage));

            Clear();
        }

        public void Export()
        {
            if (!Directory.Exists(@"training_letters\"))
                Directory.CreateDirectory(@"training_letters\");

            for (int i = 0; i < Images.Count; i++)
            {
                Bitmap bmp = Images[i];
                bmp.Save(@"training_letters\" + Labels[i] + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }                
        }

        public void Import()
        {
            string[] files = Directory.GetFiles(@"training_letters\");
            for (int i = 0; i < files.Length; i++)
            {
                _currentImage = new Bitmap(files[i]);
                string file = files[i];
                string label = file.Split(new string[] { @"\" }, StringSplitOptions.None)[1].Split('.')[0];

                for (int j = 0; j < label.ToCharArray().Length; j++)
                {
                    if (char.IsNumber(label.ToCharArray()[j]))
                    {
                        if (int.Parse(label.ToCharArray()[j] + "") > _count)
                            _count = int.Parse(label.ToCharArray()[j] + "") + 1;
                    }
                }
                Save(label);
            }
        }

        public Dictionary<string, Image<Gray, byte>> ToEigen()
        {
            Dictionary<string, Image<Gray, byte>> _dictionary = new Dictionary<string, Image<Gray, byte>>();

            for (int i = 0; i < Images.Count; i++)
            {
                Image<Gray, byte> _image = new Image<Gray, byte>(Images[i]);
                _dictionary.Add(Labels[i], _image);

            }
            return _dictionary;
        }
        
        
    }
}
