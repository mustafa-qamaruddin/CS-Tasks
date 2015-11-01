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
    public partial class Form_Task_3_b : Form
    {
        private Task_3_View_Handler obj_view_handler;

        public Form_Task_3_b()
        {
            InitializeComponent();
            obj_view_handler = new Task_3_View_Handler();
        }

        private void button_render_Click(object sender, EventArgs e)
        {
            obj_view_handler.handle_render_generate_click(this, dataGridView_meus_sigmas, dataGridView_loss_function, textBox_height, textBox_height, pictureBox_test_generated, pictureBox_generated);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_load_test_case_Click(object sender, EventArgs e)
        {
            new ReadTestCasesFromFile(this, dataGridView_meus_sigmas, dataGridView_loss_function);
        }

        private void dataGridView_meus_sigmas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }
    }
}
