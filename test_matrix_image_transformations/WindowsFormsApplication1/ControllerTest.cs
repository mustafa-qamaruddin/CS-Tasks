using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TestMatrixTransformations
{
    class ControllerTest
    {
        public void run_test(TextBox _console)
        {
            Bitmap bmp = new Bitmap(Image.FromFile("C:/lenna.png"));
            BufferedImage obj_buff_img = new BufferedImage(bmp, _console);

            ImageMatrixTransformations obj_trans = new ImageMatrixTransformations();
            BufferedImage ret = obj_trans.perform_concat_matrices_operations(obj_buff_img, _console);

            Bitmap new_bmp = ret.get_bitmap_object();
            new_bmp.Save("new_lenna.png");
        }
    }
}
