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
    public partial class Form_Task_2 : Form
    {
        public Form_Task_2()
        {
            InitializeComponent();
        }

        private void comboBox_input_image_source_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Task_2_View_Handler().render_button_handler(this, (ComboBox)sender, textBox_file_path, pictureBox_input_image, textBox_width, textBox_height, dataGridView_inputs, pictureBox_greyscale_image, pictureBox_classified);
        }

        private void button_render_Click(object sender, EventArgs e)
        {
            new Task_2_View_Handler().render_button_handler(this, comboBox_input_image_source, textBox_file_path, pictureBox_input_image, textBox_width, textBox_height, dataGridView_inputs, pictureBox_greyscale_image, pictureBox_classified);
        }

        private void dataGridView_inputs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
