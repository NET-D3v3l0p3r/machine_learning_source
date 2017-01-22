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


namespace can_sat_image.AI
{
    public class Analyzer
    {
        public Training Training { get; set; }

        public int ImageWidth { get; private set; }
        public int ImageHeight { get; private set; }

        public int PixelSize { get; private set; }
        

        private Bitmap _currentImage;
        private Graphics _device;

        private MCvTermCriteria _mcvTermCriteria;
        private EigenObjectRecognizer _eigenObjectRecognizer;

        public Analyzer(int _w, int _h, int _p)
        {
            ImageWidth = _w;
            ImageHeight = _h;

            PixelSize = _p;
        }

        public void Update(Settings settings)
        {
            _mcvTermCriteria = new MCvTermCriteria(settings.Iterations, settings.Epsilon);

            var _material = Training.ToEigen();
            _eigenObjectRecognizer = new EigenObjectRecognizer(_material.Values.ToArray(), _material.Keys.ToArray(), settings.Treshold, ref _mcvTermCriteria);
        }

        public Bitmap GetTemporary()
        {
            if (_currentImage == null)
                return new Bitmap(1, 1);
            return _currentImage;
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
        
        public string Check()
        {
            if (_eigenObjectRecognizer == null || _currentImage == null)
                return "NULL";
            var label = _eigenObjectRecognizer.Recognize(new Image<Gray, byte>(_currentImage));

            if (label != null)
                return label.Label;
            return "NULL";
        }




    }
}
