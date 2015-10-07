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
    public partial class Form_Task_1_Test_Normal_Distribution : Form
    {
        public Form_Task_1_Test_Normal_Distribution()
        {
            InitializeComponent();
        }

        private void button_render_Click(object sender, EventArgs e)
        {
            NormalDistribution obj_norm_dist = new NormalDistribution(Double.Parse(textBox_meu.Text), Double.Parse(textBox_sigma.Text));
            obj_norm_dist.fill_plot(chart_normal_distribution_probability_density_function);
        }
    }
}
