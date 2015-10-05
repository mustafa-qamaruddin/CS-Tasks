using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Patterns_Recognition___Task_1
{
    class ImageFilesHandler
    {
        public Bitmap load_image_file(Stream image_file_stream)
        {
            Image obj_img = Image.FromStream(image_file_stream);
            return new Bitmap(obj_img);
        }

        public void display_image_in_control(Bitmap img, PictureBox pic_box)
        {
            pic_box.Image = img;
        }

        public Stream open_file_dialog(Form parent_form, TextBox text_box_file_name)
        {
            OpenFileDialog file_dialog = new OpenFileDialog();
            file_dialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|BMP Files (*.bmp)|*.bmp";
            file_dialog.FilterIndex = 1;
            DialogResult clicked_result = file_dialog.ShowDialog(parent_form);
            if (clicked_result == DialogResult.OK)
            {
                update_text_box_with_file_path(text_box_file_name, file_dialog.FileName);
                return file_dialog.OpenFile();
            }
            else
            {
                return null;
            }
        }

        public void update_text_box_with_file_path(TextBox text_box, String file_path)
        {
            text_box.Text = file_path;
        }

        public void ignite(Form parent_form, PictureBox pic_box, TextBox text_box_file_name)
        {
            Stream file_stream = open_file_dialog(parent_form, text_box_file_name);
            if (file_stream == null)
                return;
            Bitmap bm = load_image_file(file_stream);
            display_image_in_control(bm, pic_box);
        }
    }
}
