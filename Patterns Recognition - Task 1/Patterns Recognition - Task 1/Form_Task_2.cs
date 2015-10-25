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
        Task_2_View_Handler mvc;
        public Form_Task_2()
        {
            InitializeComponent();
            mvc = new Task_2_View_Handler();
        }

        private void comboBox_input_image_source_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            mvc.render_button_handler(this, (ComboBox)sender, textBox_file_path, pictureBox_input_image, textBox_width, textBox_height, dataGridView_inputs, pictureBox_greyscale_image, pictureBox_classified);
            tabControl_task_2.SelectedTab = tabPage_outputs;
            Cursor.Current = Cursors.Default;
        }

        private void button_render_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            mvc.render_button_handler(this, comboBox_input_image_source, textBox_file_path, pictureBox_input_image, textBox_width, textBox_height, dataGridView_inputs, pictureBox_greyscale_image, pictureBox_classified);
            tabControl_task_2.SelectedTab = tabPage_outputs;
            Cursor.Current = Cursors.Default;
        }

        private void dataGridView_inputs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox_input_image_Click(object sender, EventArgs e)
        {
            switch (comboBox_input_image_source.SelectedIndex)
            {
                case 0:
                    int x = MousePosition.X - pictureBox_input_image.Left;
                    int y = MousePosition.Y - pictureBox_input_image.Top;
                    mvc.fill_gridview_from_mouse_clicks(dataGridView_inputs, x, y, pictureBox_classified);
                    tabControl_task_2.SelectedTab = tabPage_outputs;
                    break;
                case 1:
                    MessageBox.Show("If you want to use this option, please select file first!");
                    break;
                default:
                    break;
            };
        }

        private void pictureBox_input_image_Click_1(object sender, EventArgs e)
        {

        }

        private void button_automated_fill_Click(object sender, EventArgs e)
        {
            new ReadTestCasesFromFile(this, dataGridView_inputs);
        }

        private void pictureBox_greyscale_image_MouseClick(object sender, MouseEventArgs e)
        {
            switch (comboBox_input_image_source.SelectedIndex)
            {
                case 0:
                    int x = MousePosition.X - pictureBox_input_image.Left;
                    int y = MousePosition.Y - pictureBox_input_image.Top;
                    mvc.fill_gridview_from_mouse_clicks(dataGridView_inputs, x, y, pictureBox_classified);
                    tabControl_task_2.SelectedTab = tabPage_outputs;
                    break;
                case 1:
                    MessageBox.Show("If you want to use this option, please select file first!");
                    break;
                default:
                    break;
            };
        }
    }
}
