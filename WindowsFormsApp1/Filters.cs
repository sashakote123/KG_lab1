using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    abstract class Filters
    {


        protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int x, int y, int d, bool flag);


        public int r = 5;


        public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker, int d)
        {
            bool flag = false;
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            int w = resultImage.Width;
            int h = resultImage.Height;

   
            for (int i = 0; i < w; i++)
            {
             
                int progress = (int)((float)i / w * 100);
                worker.ReportProgress(progress);
                if (worker.CancellationPending)
                {
                    return null;
                }
                for (int j = 0; j < h; j++)
                {
                    if (j != 0)
                        flag = true;
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j, d, flag));
                }
            }
            return resultImage;
        }

      


        public int Clamp(int value, int min, int max)
        {
            if (value < min)
               return min;
            if (value > max)
                return max;
            return value;
        }




    }





}
