using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Patterns_Recognition___Task_1
{
    class ImageRectangles
    {
        const int base_color = 0,
            max_color = 255;
        public Bitmap fill_image_rects(int _width, int _height, DataGridView data_meus_sigmas)
        {
            Bitmap bmp = new Bitmap(_width, _height);
            Graphics graphics = Graphics.FromImage(bmp);
            Pen my_pen = new Pen(new SolidBrush(Color.White));
            int num_rects = data_meus_sigmas.RowCount - 1;
            int rect_width = _width / num_rects;
            for (int i = 0; i < num_rects; i++)
            {
                int r = (int)randomize_color_component(Double.Parse(data_meus_sigmas.Rows[i].Cells[0].Value.ToString()), Double.Parse(data_meus_sigmas.Rows[i].Cells[1].Value.ToString()));
                int g = (int)randomize_color_component(Double.Parse(data_meus_sigmas.Rows[i].Cells[0].Value.ToString()), Double.Parse(data_meus_sigmas.Rows[i].Cells[1].Value.ToString()));
                int b = (int)randomize_color_component(Double.Parse(data_meus_sigmas.Rows[i].Cells[0].Value.ToString()), Double.Parse(data_meus_sigmas.Rows[i].Cells[1].Value.ToString()));
                Color c = Color.FromArgb(max_color, r, g, b);
                Brush the_brush = new SolidBrush(c);
                int new_x = i * rect_width;
                graphics.FillRectangle(the_brush, new_x, 0, rect_width, _height);
                graphics.DrawLine(my_pen, new_x, 0, new_x, _height);
            }
            graphics.Flush();
            return bmp;
        }

        public double randomize_color_component(double meu, double sigma)
        {
            NormalDistribution obj_norm_dist = new NormalDistribution(meu, sigma);
            double x = obj_norm_dist.uniform_random_generator(base_color, max_color);
            return obj_norm_dist.pdf(x) * max_color;
        }
    }
}
