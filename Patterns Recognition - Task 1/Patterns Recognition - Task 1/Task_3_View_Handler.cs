using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Patterns_Recognition___Task_1
{
    class Task_3_View_Handler
    {
        public Bitmap input_image;
        public double[] samples, classes_meus_sigmas;
        public List<StateOfNature> class_regions_array;
        const int column_width = 30;

        public Task_3_View_Handler()
        {
            class_regions_array = new List<StateOfNature>();
            samples = new double[1];
            classes_meus_sigmas = new double[1];
        }

        public void handle_load_image_click(Form parent_form, TextBox text_box_file_path, PictureBox pictureBox_input_image, DataGridView dgrdview_samples, DataGridView dgrview_meu_sigma)
        {
            input_image = new ImageFilesHandler().ignite(parent_form, pictureBox_input_image, text_box_file_path);
            if (input_image != null)
            {
                dgrdview_samples.Rows.Clear();
                dgrview_meu_sigma.Rows.Clear();
            }
        }

        public void handle_input_image_mouse_click(int x, int y, DataGridView dgrdview_samples, PictureBox pictureBox_classified)
        {
            if (null == input_image || x < 0 || x >= input_image.Width || y < 0 || y >= input_image.Height)
                return;
            Color c = input_image.GetPixel(x, y);
            dgrdview_samples.Rows.Add(c.R, c.G, c.B);
            MessageBox.Show(String.Format("Click at Point := ({0}, {1}) \n\n Color (R,G,B) := {2}, {3}, {4}", x, y, c.R, c.G, c.B));
            pictureBox_classified.Image = null;
        }

        public void handle_create_classes_from_samples_click(DataGridView dgrdview_samples, DataGridView dgrview_meu_sigma, DataGridView dgrdview_loss_function)
        {
            StateOfNature state_of_nature = new StateOfNature();
            for (int i = 0; i < dgrdview_samples.Rows.Count; i++)
            {
                if (dgrdview_samples.Rows[i].Cells[0].Value == null || dgrdview_samples.Rows[i].Cells[1].Value == null || dgrdview_samples.Rows[i].Cells[2].Value == null)
                    continue;
                int r = int.Parse(dgrdview_samples.Rows[i].Cells[0].Value.ToString());
                int g = int.Parse(dgrdview_samples.Rows[i].Cells[1].Value.ToString());
                int b = int.Parse(dgrdview_samples.Rows[i].Cells[2].Value.ToString());
                Color c = Color.FromArgb(r, g, b);
                state_of_nature.samples.Add(c);
            }
            state_of_nature.calculate_meus_and_sigmas_from_samples();
            dgrview_meu_sigma.Rows.Add(state_of_nature.meu_red, state_of_nature.sigma_red, state_of_nature.meu_green, state_of_nature.sigma_green, state_of_nature.meu_blue, state_of_nature.sigma_blue);
            class_regions_array.Add(state_of_nature);
            DataGridViewColumn dgrdview_col = new DataGridViewColumn();
            dgrdview_col.Width = column_width;
            dgrdview_col.Name = "w_" + class_regions_array.Count;
            dgrdview_col.HeaderText = "w" + class_regions_array.Count;
            dgrdview_col.CellTemplate = dgrdview_samples.Rows[0].Cells[0];
            dgrdview_loss_function.Columns.Add(dgrdview_col);
            dgrdview_samples.Rows.Clear();
        }

        public void handle_render_image_click(PictureBox classified_image)
        {

        }
    }
}
