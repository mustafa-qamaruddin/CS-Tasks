using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace Patterns_Recognition___Task_1
{
    class ImageProcessing
    {
        public Bitmap get_grey_scale(Bitmap bmp)
        {
            if (bmp == null)
                return null;
            Bitmap ret = new Bitmap(bmp.Width, bmp.Height);
            for (int x = 0; x < bmp.Width; x++ )
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color original_color = bmp.GetPixel(x, y);
                    int grey_level = (original_color.R + original_color.G + original_color.B) / 3;
                    ret.SetPixel(x, y, Color.FromArgb(grey_level, grey_level, grey_level));
                }
            }
            return ret;
        }
    }
}
