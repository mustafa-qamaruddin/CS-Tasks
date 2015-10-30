using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Patterns_Recognition___Task_1
{
    public partial class Form_Task_3_a : Form
    {
        private Task_3_View_Handler obj_view_handler;

        public Form_Task_3_a()
        {
            InitializeComponent();
            obj_view_handler = new Task_3_View_Handler();
        }

        private void button_load_image_file_Click(object sender, EventArgs e)
        {
            obj_view_handler.handle_load_image_click(this, textBox_file_path, pictureBox_input, dataGridView_samples, dataGridView_meu_sigma);
        }

        private void pictureBox_input_MouseClick(object sender, MouseEventArgs e)
        {
            obj_view_handler.handle_input_image_mouse_click(e.X, e.Y, dataGridView_samples, pictureBox_output);
        }

        private void button_create_class_from_sample_Click(object sender, EventArgs e)
        {
            obj_view_handler.handle_create_classes_from_samples_click(dataGridView_samples, dataGridView_meu_sigma, dataGridView_loss_function);
        }

        private void button_render_Click(object sender, EventArgs e)
        {
            pictureBox_output.Image = obj_view_handler.handle_render_image_click(dataGridView_loss_function);
        }
    }
}
