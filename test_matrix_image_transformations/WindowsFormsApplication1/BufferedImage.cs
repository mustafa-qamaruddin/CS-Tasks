using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TestMatrixTransformations
{
    class BufferedImage
    {
        public int width, height;
        public Color[,] buffer;

        public BufferedImage(int _width, int _height) {
            width = _width;
            height = _height;
            buffer = new Color[_width, _height];
        }

        public BufferedImage(Bitmap bmp, TextBox _console)
        {
            buffer = new Color[bmp.Width, bmp.Height];
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    _console.Text += "Load P(" + i + ", " + j + ")";
                    _console.Text += Environment.NewLine;
                    Color c = bmp.GetPixel(i, j);
                    _console.Text += "Load Color(" + c.R + ", " + c.G + ", " + c.B + ")";
                    _console.Text += Environment.NewLine;
                    buffer[i, j] = c;
                }
            }
        }

        public Bitmap get_bitmap_object()
        {
            return new Bitmap(width, height);
        }
    }
}
