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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_task_1_Click(object sender, EventArgs e)
        {
            new Form_Task_1().Show();
        }

        private void button_task_2_Click(object sender, EventArgs e)
        {
            Form target_window = new Form_Task_2();
            target_window.Show();
            target_window.WindowState = FormWindowState.Maximized;
        }
    }
}
