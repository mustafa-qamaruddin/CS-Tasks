namespace Patterns_Recognition___Task_1
{
    partial class Form_Task_1_Test_Normal_Distribution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label_meu = new System.Windows.Forms.Label();
            this.textBox_meu = new System.Windows.Forms.TextBox();
            this.label_sigma = new System.Windows.Forms.Label();
            this.textBox_sigma = new System.Windows.Forms.TextBox();
            this.button_render = new System.Windows.Forms.Button();
            this.chart_normal_distribution_probability_density_function = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_normal_distribution_probability_density_function)).BeginInit();
            this.SuspendLayout();
            // 
            // label_meu
            // 
            this.label_meu.AutoSize = true;
            this.label_meu.Location = new System.Drawing.Point(0, 3);
            this.label_meu.Name = "label_meu";
            this.label_meu.Size = new System.Drawing.Size(28, 13);
            this.label_meu.TabIndex = 0;
            this.label_meu.Text = "Meu";
            // 
            // textBox_meu
            // 
            this.textBox_meu.Location = new System.Drawing.Point(34, 0);
            this.textBox_meu.Name = "textBox_meu";
            this.textBox_meu.Size = new System.Drawing.Size(39, 20);
            this.textBox_meu.TabIndex = 1;
            // 
            // label_sigma
            // 
            this.label_sigma.AutoSize = true;
            this.label_sigma.Location = new System.Drawing.Point(83, 3);
            this.label_sigma.Name = "label_sigma";
            this.label_sigma.Size = new System.Drawing.Size(36, 13);
            this.label_sigma.TabIndex = 0;
            this.label_sigma.Text = "Sigma";
            // 
            // textBox_sigma
            // 
            this.textBox_sigma.Location = new System.Drawing.Point(117, 0);
            this.textBox_sigma.Name = "textBox_sigma";
            this.textBox_sigma.Size = new System.Drawing.Size(39, 20);
            this.textBox_sigma.TabIndex = 1;
            // 
            // button_render
            // 
            this.button_render.Location = new System.Drawing.Point(175, 0);
            this.button_render.Name = "button_render";
            this.button_render.Size = new System.Drawing.Size(75, 20);
            this.button_render.TabIndex = 2;
            this.button_render.Text = "Render";
            this.button_render.UseVisualStyleBackColor = true;
            this.button_render.Click += new System.EventHandler(this.button_render_Click);
            // 
            // chart_normal_distribution_probability_density_function
            // 
            chartArea2.Name = "ChartArea_Normal_Distribution_PDF";
            this.chart_normal_distribution_probability_density_function.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_normal_distribution_probability_density_function.Legends.Add(legend2);
            this.chart_normal_distribution_probability_density_function.Location = new System.Drawing.Point(3, 26);
            this.chart_normal_distribution_probability_density_function.Name = "chart_normal_distribution_probability_density_function";
            series2.ChartArea = "ChartArea_Normal_Distribution_PDF";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Normal Distribution";
            this.chart_normal_distribution_probability_density_function.Series.Add(series2);
            this.chart_normal_distribution_probability_density_function.Size = new System.Drawing.Size(788, 547);
            this.chart_normal_distribution_probability_density_function.TabIndex = 3;
            this.chart_normal_distribution_probability_density_function.Text = "chart_normal_distribution_pdf";
            // 
            // Form_Task_1_Test_Normal_Distribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.chart_normal_distribution_probability_density_function);
            this.Controls.Add(this.button_render);
            this.Controls.Add(this.textBox_sigma);
            this.Controls.Add(this.textBox_meu);
            this.Controls.Add(this.label_sigma);
            this.Controls.Add(this.label_meu);
            this.Name = "Form_Task_1_Test_Normal_Distribution";
            this.Text = "Form_Task_1_Test_Normal_Distribution";
            ((System.ComponentModel.ISupportInitialize)(this.chart_normal_distribution_probability_density_function)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_meu;
        private System.Windows.Forms.TextBox textBox_meu;
        private System.Windows.Forms.Label label_sigma;
        private System.Windows.Forms.TextBox textBox_sigma;
        private System.Windows.Forms.Button button_render;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_normal_distribution_probability_density_function;
    }
}