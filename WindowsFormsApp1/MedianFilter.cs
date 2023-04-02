using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    internal class MedianFilter : Filters
    {

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y, int d, bool flag)
        {
            int size = 3;
            int radius = 1;

            List<int> cR = new List<int>();
            List<int> cG = new List<int>();
            List<int> cB = new List<int>();


            for (int i = -radius; i <= radius; i++)
                for (int j = -radius; j <= radius; j++)
                {
                    Color sourceColor = sourceImage.GetPixel(Clamp(x + i, 0, sourceImage.Width - 1), Clamp(y + j, 0, sourceImage.Height - 1));
                    cR.Add(sourceColor.R);
                    cG.Add(sourceColor.G);
                    cB.Add(sourceColor.B);

                }

            cR.Sort();
            cG.Sort();
            cB.Sort();

            int median = (size * size / 2);

            int cR_ = cR[median];
            int cG_ = cG[median];
            int cB_ = cB[median];

            Color resultColor = Color.FromArgb(cR_, cG_, cB_);
            return resultColor;
        }
     
    }
}
