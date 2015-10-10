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
    public partial class Form_Task_1_b : Form
    {
        public Form_Task_1_b()
        {
            InitializeComponent();
        }

        private void dataGridView_Meus_Sigmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_render_Click(object sender, EventArgs e)
        {
            ImageRectangles obj_ir = new ImageRectangles();
            pictureBox_image.Image = obj_ir.fill_image_rects(Int32.Parse(textBox_width.Text), Int32.Parse(textBox_height.Text), dataGridView_Meus_Sigmas);
        }

        private void dataGridView_Meus_Sigmas_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // red
            e.Row.Cells[0].Value = 4;
            e.Row.Cells[1].Value = 0.5;

            // green
            e.Row.Cells[2].Value = 4;
            e.Row.Cells[3].Value = 0.5;

            // blue
            e.Row.Cells[4].Value = 4;
            e.Row.Cells[5].Value = 0.5;
        }
    }
}
