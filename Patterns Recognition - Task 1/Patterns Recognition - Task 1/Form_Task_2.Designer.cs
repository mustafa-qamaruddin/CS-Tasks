namespace Patterns_Recognition___Task_1
{
    partial class Form_Task_2
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
            this.tabControl_task_2 = new System.Windows.Forms.TabControl();
            this.tabPage_inputs = new System.Windows.Forms.TabPage();
            this.button_automated_fill = new System.Windows.Forms.Button();
            this.textBox_file_path = new System.Windows.Forms.TextBox();
            this.button_render = new System.Windows.Forms.Button();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.label_height = new System.Windows.Forms.Label();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.label_width = new System.Windows.Forms.Label();
            this.pictureBox_input_image = new System.Windows.Forms.PictureBox();
            this.comboBox_input_image_source = new System.Windows.Forms.ComboBox();
            this.label_input_source = new System.Windows.Forms.Label();
            this.dataGridView_inputs = new System.Windows.Forms.DataGridView();
            this.RMeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RSigma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GMeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GSigma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BMeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSigma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_outputs = new System.Windows.Forms.TabPage();
            this.pictureBox_classified = new System.Windows.Forms.PictureBox();
            this.pictureBox_greyscale_image = new System.Windows.Forms.PictureBox();
            this.tabControl_task_2.SuspendLayout();
            this.tabPage_inputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_input_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inputs)).BeginInit();
            this.tabPage_outputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_classified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_greyscale_image)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_task_2
            // 
            this.tabControl_task_2.Controls.Add(this.tabPage_inputs);
            this.tabControl_task_2.Controls.Add(this.tabPage_outputs);
            this.tabControl_task_2.Location = new System.Drawing.Point(0, 0);
            this.tabControl_task_2.Name = "tabControl_task_2";
            this.tabControl_task_2.SelectedIndex = 0;
            this.tabControl_task_2.Size = new System.Drawing.Size(1042, 751);
            this.tabControl_task_2.TabIndex = 0;
            // 
            // tabPage_inputs
            // 
            this.tabPage_inputs.Controls.Add(this.button_automated_fill);
            this.tabPage_inputs.Controls.Add(this.textBox_file_path);
            this.tabPage_inputs.Controls.Add(this.button_render);
            this.tabPage_inputs.Controls.Add(this.textBox_height);
            this.tabPage_inputs.Controls.Add(this.label_height);
            this.tabPage_inputs.Controls.Add(this.textBox_width);
            this.tabPage_inputs.Controls.Add(this.label_width);
            this.tabPage_inputs.Controls.Add(this.pictureBox_input_image);
            this.tabPage_inputs.Controls.Add(this.comboBox_input_image_source);
            this.tabPage_inputs.Controls.Add(this.label_input_source);
            this.tabPage_inputs.Controls.Add(this.dataGridView_inputs);
            this.tabPage_inputs.Location = new System.Drawing.Point(4, 22);
            this.tabPage_inputs.Name = "tabPage_inputs";
            this.tabPage_inputs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_inputs.Size = new System.Drawing.Size(1034, 725);
            this.tabPage_inputs.TabIndex = 0;
            this.tabPage_inputs.Text = "Inputs";
            this.tabPage_inputs.UseVisualStyleBackColor = true;
            // 
            // button_automated_fill
            // 
            this.button_automated_fill.Location = new System.Drawing.Point(0, 3);
            this.button_automated_fill.Name = "button_automated_fill";
            this.button_automated_fill.Size = new System.Drawing.Size(288, 23);
            this.button_automated_fill.TabIndex = 8;
            this.button_automated_fill.Text = "Automated Testing";
            this.button_automated_fill.UseVisualStyleBackColor = true;
            this.button_automated_fill.Click += new System.EventHandler(this.button_automated_fill_Click);
            // 
            // textBox_file_path
            // 
            this.textBox_file_path.Location = new System.Drawing.Point(713, 3);
            this.textBox_file_path.Name = "textBox_file_path";
            this.textBox_file_path.Size = new System.Drawing.Size(218, 20);
            this.textBox_file_path.TabIndex = 7;
            // 
            // button_render
            // 
            this.button_render.Location = new System.Drawing.Point(937, 3);
            this.button_render.Name = "button_render";
            this.button_render.Size = new System.Drawing.Size(75, 20);
            this.button_render.TabIndex = 6;
            this.button_render.Text = "Render";
            this.button_render.UseVisualStyleBackColor = true;
            this.button_render.Click += new System.EventHandler(this.button_render_Click);
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(673, 3);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(34, 20);
            this.textBox_height.TabIndex = 5;
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(629, 6);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(38, 13);
            this.label_height.TabIndex = 4;
            this.label_height.Text = "Height";
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(589, 3);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(34, 20);
            this.textBox_width.TabIndex = 5;
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(548, 6);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(35, 13);
            this.label_width.TabIndex = 4;
            this.label_width.Text = "Width";
            // 
            // pictureBox_input_image
            // 
            this.pictureBox_input_image.Location = new System.Drawing.Point(294, 30);
            this.pictureBox_input_image.Name = "pictureBox_input_image";
            this.pictureBox_input_image.Size = new System.Drawing.Size(718, 692);
            this.pictureBox_input_image.TabIndex = 3;
            this.pictureBox_input_image.TabStop = false;
            this.pictureBox_input_image.Click += new System.EventHandler(this.pictureBox_input_image_Click_1);
            this.pictureBox_input_image.MouseCaptureChanged += new System.EventHandler(this.pictureBox_input_image_Click);
            // 
            // comboBox_input_image_source
            // 
            this.comboBox_input_image_source.FormattingEnabled = true;
            this.comboBox_input_image_source.Items.AddRange(new object[] {
            "Open Image File",
            "Generate RGB Image "});
            this.comboBox_input_image_source.Location = new System.Drawing.Point(400, 3);
            this.comboBox_input_image_source.Name = "comboBox_input_image_source";
            this.comboBox_input_image_source.Size = new System.Drawing.Size(142, 21);
            this.comboBox_input_image_source.TabIndex = 2;
            this.comboBox_input_image_source.SelectedIndexChanged += new System.EventHandler(this.comboBox_input_image_source_SelectedIndexChanged);
            // 
            // label_input_source
            // 
            this.label_input_source.AutoSize = true;
            this.label_input_source.Location = new System.Drawing.Point(294, 6);
            this.label_input_source.Name = "label_input_source";
            this.label_input_source.Size = new System.Drawing.Size(100, 13);
            this.label_input_source.TabIndex = 1;
            this.label_input_source.Text = "Input Image Source";
            // 
            // dataGridView_inputs
            // 
            this.dataGridView_inputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_inputs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RMeu,
            this.RSigma,
            this.GMeu,
            this.GSigma,
            this.BMeu,
            this.BSigma,
            this.Prior});
            this.dataGridView_inputs.Location = new System.Drawing.Point(0, 30);
            this.dataGridView_inputs.Name = "dataGridView_inputs";
            this.dataGridView_inputs.Size = new System.Drawing.Size(288, 695);
            this.dataGridView_inputs.TabIndex = 0;
            this.dataGridView_inputs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_inputs_CellContentClick);
            // 
            // RMeu
            // 
            this.RMeu.HeaderText = "Meu Red";
            this.RMeu.Name = "RMeu";
            this.RMeu.Width = 35;
            // 
            // RSigma
            // 
            this.RSigma.HeaderText = "Sigma Red";
            this.RSigma.Name = "RSigma";
            this.RSigma.Width = 35;
            // 
            // GMeu
            // 
            this.GMeu.HeaderText = "Meu Green";
            this.GMeu.Name = "GMeu";
            this.GMeu.Width = 35;
            // 
            // GSigma
            // 
            this.GSigma.HeaderText = "Sigma Green";
            this.GSigma.Name = "GSigma";
            this.GSigma.Width = 35;
            // 
            // BMeu
            // 
            this.BMeu.HeaderText = "Meu Blue";
            this.BMeu.Name = "BMeu";
            this.BMeu.Width = 35;
            // 
            // BSigma
            // 
            this.BSigma.HeaderText = "Sigma Blue";
            this.BSigma.Name = "BSigma";
            this.BSigma.Width = 35;
            // 
            // Prior
            // 
            this.Prior.HeaderText = "Prior Probability";
            this.Prior.Name = "Prior";
            this.Prior.Width = 35;
            // 
            // tabPage_outputs
            // 
            this.tabPage_outputs.Controls.Add(this.pictureBox_classified);
            this.tabPage_outputs.Controls.Add(this.pictureBox_greyscale_image);
            this.tabPage_outputs.Location = new System.Drawing.Point(4, 22);
            this.tabPage_outputs.Name = "tabPage_outputs";
            this.tabPage_outputs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_outputs.Size = new System.Drawing.Size(1034, 725);
            this.tabPage_outputs.TabIndex = 1;
            this.tabPage_outputs.Text = "Outputs";
            this.tabPage_outputs.UseVisualStyleBackColor = true;
            // 
            // pictureBox_classified
            // 
            this.pictureBox_classified.Location = new System.Drawing.Point(506, 0);
            this.pictureBox_classified.Name = "pictureBox_classified";
            this.pictureBox_classified.Size = new System.Drawing.Size(500, 725);
            this.pictureBox_classified.TabIndex = 0;
            this.pictureBox_classified.TabStop = false;
            // 
            // pictureBox_greyscale_image
            // 
            this.pictureBox_greyscale_image.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_greyscale_image.Name = "pictureBox_greyscale_image";
            this.pictureBox_greyscale_image.Size = new System.Drawing.Size(500, 725);
            this.pictureBox_greyscale_image.TabIndex = 0;
            this.pictureBox_greyscale_image.TabStop = false;
            this.pictureBox_greyscale_image.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_greyscale_image_MouseClick);
            // 
            // Form_Task_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 753);
            this.Controls.Add(this.tabControl_task_2);
            this.Name = "Form_Task_2";
            this.Text = "Task 2";
            this.tabControl_task_2.ResumeLayout(false);
            this.tabPage_inputs.ResumeLayout(false);
            this.tabPage_inputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_input_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inputs)).EndInit();
            this.tabPage_outputs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_classified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_greyscale_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_task_2;
        private System.Windows.Forms.TabPage tabPage_inputs;
        private System.Windows.Forms.ComboBox comboBox_input_image_source;
        private System.Windows.Forms.Label label_input_source;
        private System.Windows.Forms.DataGridView dataGridView_inputs;
        private System.Windows.Forms.TabPage tabPage_outputs;
        private System.Windows.Forms.PictureBox pictureBox_input_image;
        private System.Windows.Forms.Button button_render;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.TextBox textBox_file_path;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMeu;
        private System.Windows.Forms.DataGridViewTextBoxColumn RSigma;
        private System.Windows.Forms.DataGridViewTextBoxColumn GMeu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSigma;
        private System.Windows.Forms.DataGridViewTextBoxColumn BMeu;
        private System.Windows.Forms.DataGridViewTextBoxColumn BSigma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prior;
        private System.Windows.Forms.PictureBox pictureBox_classified;
        private System.Windows.Forms.PictureBox pictureBox_greyscale_image;
        private System.Windows.Forms.Button button_automated_fill;
    }
}