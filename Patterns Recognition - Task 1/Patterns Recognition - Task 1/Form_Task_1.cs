using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patterns_Recognition___Task_1
{
    public partial class Form_Task_1 : Form
    {
        public Form_Task_1()
        {
            InitializeComponent();
        }

        private void button_pr_load_img_file_Click(object sender, EventArgs e)
        {
            ImageFilesHandler img_files_handler = new ImageFilesHandler();
            img_files_handler.ignite(this, picture_box_pr, text_box_pr_img_src);
        }
    }
}
