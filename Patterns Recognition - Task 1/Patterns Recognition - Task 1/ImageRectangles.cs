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
        public Bitmap fill_image_rects(int _width, int _height, DataGridView data_meus_sigmas, bool bool_pixels)
        {
            Bitmap bmp = new Bitmap(_width, _height);
            Graphics graphics = Graphics.FromImage(bmp);
            Pen my_pen = new Pen(new SolidBrush(Color.White));
            int num_rects = data_meus_sigmas.RowCount;
            int rect_width = _width / num_rects;
            for (int i = 0; i < num_rects; i++)
            {
                if (data_meus_sigmas.Rows[i].Cells[0].Value == null)
                    continue;
                
                if (bool_pixels) // draw pixel by pixel
                {
                    render_pixels(ref bmp, i, rect_width, _height, data_meus_sigmas.Rows[i]);
                }
                else
                {
                    render_rectangles(ref graphics, i, rect_width, _height, my_pen, data_meus_sigmas.Rows[i]);
                }
            }
            graphics.Flush();
            return bmp;
        }

        public void render_pixels(ref Bitmap obj_bitmap, int x_offset, int rect_width, int _height, DataGridViewRow dgvr) {
            Color c;
            for(int i = x_offset * rect_width; i < x_offset * rect_width + rect_width; i++){
                for(int j = 0; j < _height; j++){
                    c = get_random_color_intensity(dgvr);
                    obj_bitmap.SetPixel(i, j, c);
                }
            }
        }

        public void render_rectangles(ref Graphics graphics, int i, int rect_width, int _height, Pen my_pen, DataGridViewRow dgvr)
        {
            Color c = get_random_color_intensity(dgvr);
            Brush the_brush = new SolidBrush(c);
            int new_x = i * rect_width;
            graphics.FillRectangle(the_brush, new_x, 0, rect_width, _height);
            graphics.DrawLine(my_pen, new_x, 0, new_x, _height);
        }

        public Color get_random_color_intensity(DataGridViewRow data_meus_sigmas_row)
        {
            int r = (int)randomize_color_component(Double.Parse(data_meus_sigmas_row.Cells[0].Value.ToString()), Double.Parse(data_meus_sigmas_row.Cells[1].Value.ToString()));
            int g = (int)randomize_color_component(Double.Parse(data_meus_sigmas_row.Cells[2].Value.ToString()), Double.Parse(data_meus_sigmas_row.Cells[3].Value.ToString()));
            int b = (int)randomize_color_component(Double.Parse(data_meus_sigmas_row.Cells[4].Value.ToString()), Double.Parse(data_meus_sigmas_row.Cells[5].Value.ToString()));
            return Color.FromArgb(max_color, r, g, b);
        }

        public double randomize_color_component(double meu, double sigma)
        {
            Mueller_Box_Normal_RGNR rnd = new Mueller_Box_Normal_RGNR(meu, sigma);
            double ret = rnd.generate_normal_random();
            if (ret > max_color)
                ret = ret % (max_color+1);
            if (ret < base_color)
                ret = Math.Abs(ret%(max_color+1));
            return ret;
        }
    }
}
