using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using WindowsFormsApp1;

namespace WindowsFormsApp1
    {



        internal class BlackAndWhite : Filters
        {

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y, int d, bool flag)
            {
                Color sourceColor = sourceImage.GetPixel(x, y);
                Color resultColor = Color.FromArgb(sourceColor.R, sourceColor.R, sourceColor.R);
                return resultColor;
            }



    }
    }



