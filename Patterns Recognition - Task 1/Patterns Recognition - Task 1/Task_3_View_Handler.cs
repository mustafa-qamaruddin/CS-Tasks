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
        public List<StateOfNature> class_regions_array;
        const int column_width = 30;
        Unique_Random_Color obj_unique_random_colors_array;
        double[,] lambda;

        const int default_width = 480;
        const int default_height = 640;

        const int max_color = 255;
        const int min_color = 0;

        int[,] confusion_matrix;

        public Task_3_View_Handler()
        {
            class_regions_array = new List<StateOfNature>();
            obj_unique_random_colors_array = new Unique_Random_Color();
        }

        public void handle_load_image_click(Form parent_form, TextBox text_box_file_path, PictureBox pictureBox_input_image, DataGridView dgrdview_samples, DataGridView dgrview_meu_sigma, DataGridView dgrdview_lambda)
        {
            input_image = new ImageFilesHandler().ignite(parent_form, pictureBox_input_image, text_box_file_path);
            if (input_image != null)
            {
                dgrdview_samples.Rows.Clear();
                dgrview_meu_sigma.Rows.Clear();
                dgrdview_lambda.Columns.Clear();
                new DataGridView_Helpers().add_grid_column("actions", "a", dgrview_meu_sigma.Rows[0].Cells[0], dgrdview_lambda);
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
            state_of_nature.color = obj_unique_random_colors_array.get_unique_random_color();
            class_regions_array.Add(state_of_nature);
            // add a column for the new class wi in lambda matrix
            DataGridViewColumn dgrdview_col = new DataGridViewColumn();
            dgrdview_col.Width = column_width;
            dgrdview_col.Name = "w_" + class_regions_array.Count;
            dgrdview_col.HeaderText = "w" + class_regions_array.Count;
            dgrdview_col.CellTemplate = dgrdview_samples.Rows[0].Cells[0];
            dgrdview_loss_function.Columns.Add(dgrdview_col);
            // clear samples table
            dgrdview_samples.Rows.Clear();
        }

        public Bitmap handle_render_image_click(DataGridView dgrdview_loss_function, bool is_confused = false)
        {
            propagate_loss_function_lambda_matrix(dgrdview_loss_function);
            Bitmap ret = new Bitmap(input_image.Width, input_image.Height);
            if (class_regions_array == null)
                return ret;
            for (int x = 0; x < input_image.Width; x++)
            {
                for (int y = 0; y < input_image.Height; y++)
                {
                    Color original_color = input_image.GetPixel(x, y);
                    int[] observed_features_vector_x = new int[] { original_color.R, original_color.G, original_color.B };
                    int class_index = new BayesianInferenceEngine().classify(class_regions_array, observed_features_vector_x, lambda);
                    if (class_index == -1 || class_index == class_regions_array.Count)
                        ret.SetPixel(x, y, Color.Black);
                    else
                        ret.SetPixel(x, y, class_regions_array[class_index].color);

                    if (is_confused)
                        update_confusion_matrix(x, y, class_index);
                }
            }
            return ret;
        }

        public bool update_confusion_matrix(int x, int y, int class_index)
        {
            for (int i = 0; i < class_regions_array.Count; i++)
            {
                if (x < class_regions_array[i].x2 && x >= class_regions_array[i].x1)
                {
                    if (y < class_regions_array[i].y2 && y >= class_regions_array[i].y1)
                    {
                        if (class_index == i)
                        {
                            confusion_matrix[class_index, class_index]++;
                            return true;
                        }
                        else
                        {
                            confusion_matrix[class_index, i]++;
                            return false;
                        }
                    }
                }
            }
            return false;
        }

        public void handle_render_generate_click(Form parent_form, DataGridView dgrdview_meus_sigmas, DataGridView dgrdview_loss_function_lambda, TextBox textBox_width, TextBox textBox_height, PictureBox picbox_test_generated, PictureBox picbox_generated)
        {
            int image_width = default_width;
            if (!String.IsNullOrEmpty(textBox_width.Text))
                image_width = Int32.Parse(textBox_width.Text);

            int image_height = default_height;
            if (!String.IsNullOrEmpty(textBox_height.Text))
                image_height = Int32.Parse(textBox_height.Text);

            propagate_states_of_nature(dgrdview_meus_sigmas, image_width, image_height);
            //propagate_loss_function_lambda_matrix(dgrdview_loss_function_lambda);

            input_image = new ImageRectangles().fill_image_rects(image_width, image_height, dgrdview_meus_sigmas, true);
            picbox_test_generated.Image = input_image;
            picbox_generated.Image = handle_render_image_click(dgrdview_loss_function_lambda, true);
            display_confusion_matrix(parent_form, dgrdview_meus_sigmas);
        }

        public double calculate_overall_accuracy()
        {
            double over_all_accuracy = 0;
            for (int i = 0; i < class_regions_array.Count; i++)
            {
                over_all_accuracy += confusion_matrix[i, i];
            }
            over_all_accuracy /= (input_image.Width * input_image.Height);
            return over_all_accuracy;
        }

        public void display_confusion_matrix(Form parent_form, DataGridView dgrdv)
        {
            Form child_form = new Form();
            DataGridView dgrdv_confusion = new DataGridView();
            DataGridView_Helpers obj_dgrdv_helpers = new DataGridView_Helpers();
            int column_index;
            obj_dgrdv_helpers.add_grid_column("actions", "a", dgrdv.Rows[0].Cells[0], dgrdv_confusion);
            for (int i = 0; i < class_regions_array.Count; i++)
            {
                column_index = i + 1;
                obj_dgrdv_helpers.add_grid_column("w" + column_index, "w" + column_index, dgrdv.Rows[0].Cells[0], dgrdv_confusion);
            }
            dgrdv_confusion.Rows.Add(class_regions_array.Count+1);
            int row_index;
            for (int i = 0; i < class_regions_array.Count + 1; i++)
            {
                row_index = i + 1;
                for (int j = 0; j < class_regions_array.Count+1; j++)
                {
                    if (j == 0)
                        dgrdv_confusion.Rows[i].Cells[j].Value = "a" + row_index;
                    else
                        dgrdv_confusion.Rows[i].Cells[j].Value = confusion_matrix[i, j - 1];
                }
            }
            
            dgrdv_confusion.Location = new System.Drawing.Point(0, 0);
            dgrdv_confusion.Name = "dataGridView_confusion_matrix";
            dgrdv_confusion.Size = new System.Drawing.Size(250, 150);
            child_form.Controls.Add(dgrdv_confusion);
            child_form.Owner = parent_form;
            child_form.Show();
            MessageBox.Show(String.Format("Overall Accuracy ={0}", calculate_overall_accuracy()));
        }

        public void propagate_states_of_nature(DataGridView data_meus_sigmas, int _width, int _height)
        {
            class_regions_array = new List<StateOfNature>();
            int num_rects = data_meus_sigmas.RowCount;
            if (num_rects == 1 && data_meus_sigmas.Rows[0].Cells[0].Value == null)
                return;
            // correct num rects
            int correct_num_rects = 0;
            for (int i = 0; i < num_rects; i++)
            {
                if (new DataGridView_Helpers().is_grid_row_empty(data_meus_sigmas.Rows[i]))
                    continue;
                correct_num_rects++;
            }
            num_rects = correct_num_rects;
            // end correction
            int rect_width = _width / num_rects;
            for (int i = 0; i < num_rects; i++)
            {
                StateOfNature state_of_nature = new StateOfNature();
                state_of_nature.width = rect_width;
                state_of_nature.height = _height;
                state_of_nature.x1 = i * rect_width;
                state_of_nature.y1 = 0;
                state_of_nature.x2 = i * rect_width + rect_width;
                state_of_nature.y2 = _height;
                state_of_nature.meu_red = Double.Parse(data_meus_sigmas.Rows[i].Cells[0].Value.ToString());
                state_of_nature.meu_green = Double.Parse(data_meus_sigmas.Rows[i].Cells[2].Value.ToString());
                state_of_nature.meu_blue = Double.Parse(data_meus_sigmas.Rows[i].Cells[4].Value.ToString());
                state_of_nature.sigma_red = Double.Parse(data_meus_sigmas.Rows[i].Cells[1].Value.ToString());
                state_of_nature.sigma_green = Double.Parse(data_meus_sigmas.Rows[i].Cells[3].Value.ToString());
                state_of_nature.sigma_blue = Double.Parse(data_meus_sigmas.Rows[i].Cells[5].Value.ToString());
                state_of_nature.prior = Double.Parse(data_meus_sigmas.Rows[i].Cells[6].Value.ToString());
                state_of_nature.color = obj_unique_random_colors_array.get_unique_random_color();
                class_regions_array.Add(state_of_nature);
            }
        }

        public void propagate_loss_function_lambda_matrix(DataGridView dgrdv_lambda)
        {
            // correct num actions
            int correct_num_actions = 0;
            for (int i = 0; i < dgrdv_lambda.Rows.Count; i++)
            {
                if (new DataGridView_Helpers().is_grid_row_empty(dgrdv_lambda.Rows[i]))
                    continue;
                correct_num_actions++;
            }
            // end correction
            lambda = new double[correct_num_actions, class_regions_array.Count];
            confusion_matrix = new int[correct_num_actions, class_regions_array.Count];
            for (int i = 0; i < correct_num_actions; i++) // loop actions
            {
                for (int j = 0; j < class_regions_array.Count; j++) // loop states of nature (categories)
                {
                    if (dgrdv_lambda.Rows[i].Cells[j + 1].Value != null)
                        lambda[i, j] = double.Parse(dgrdv_lambda.Rows[i].Cells[j + 1].Value.ToString());
                }
            }
        }
    }
}
