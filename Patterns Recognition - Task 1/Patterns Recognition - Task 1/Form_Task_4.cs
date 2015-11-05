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
    public partial class Form_Task_4 : Form
    {
        Task_4_View_Handler object_view_handler;

        public Form_Task_4()
        {
            InitializeComponent();
            object_view_handler = new Task_4_View_Handler();
        }

        private void button_load_data_set_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            object_view_handler.handle_load_data_set_button_click(this, textBox_file_path, dataGridView_confusion_matrix, textBox_overall_accuracy);
            Cursor.Current = Cursors.Default;
        }
    }
}
