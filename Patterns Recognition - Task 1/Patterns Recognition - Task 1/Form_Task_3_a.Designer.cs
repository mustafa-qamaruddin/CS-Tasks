namespace Patterns_Recognition___Task_1
{
    partial class Form_Task_3_a
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
            this.textBox_file_path = new System.Windows.Forms.TextBox();
            this.button_load_image_file = new System.Windows.Forms.Button();
            this.dataGridView_samples = new System.Windows.Forms.DataGridView();
            this.Red = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Green = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_meu_sigma = new System.Windows.Forms.DataGridView();
            this.button_create_class_from_sample = new System.Windows.Forms.Button();
            this.MeuR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SigmaR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeuG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SigmaG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeuB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SigmaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_render = new System.Windows.Forms.Button();
            this.pictureBox_input = new System.Windows.Forms.PictureBox();
            this.pictureBox_output = new System.Windows.Forms.PictureBox();
            this.dataGridView_loss_function = new System.Windows.Forms.DataGridView();
            this.label_loss_function = new System.Windows.Forms.Label();
            this.actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_samples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_meu_sigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_loss_function)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_file_path
            // 
            this.textBox_file_path.Location = new System.Drawing.Point(0, 0);
            this.textBox_file_path.Name = "textBox_file_path";
            this.textBox_file_path.Size = new System.Drawing.Size(159, 20);
            this.textBox_file_path.TabIndex = 0;
            // 
            // button_load_image_file
            // 
            this.button_load_image_file.Location = new System.Drawing.Point(165, 0);
            this.button_load_image_file.Name = "button_load_image_file";
            this.button_load_image_file.Size = new System.Drawing.Size(75, 20);
            this.button_load_image_file.TabIndex = 1;
            this.button_load_image_file.Text = "Load";
            this.button_load_image_file.UseVisualStyleBackColor = true;
            this.button_load_image_file.Click += new System.EventHandler(this.button_load_image_file_Click);
            // 
            // dataGridView_samples
            // 
            this.dataGridView_samples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_samples.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Red,
            this.Green,
            this.Blue});
            this.dataGridView_samples.Location = new System.Drawing.Point(0, 26);
            this.dataGridView_samples.Name = "dataGridView_samples";
            this.dataGridView_samples.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_samples.TabIndex = 2;
            // 
            // Red
            // 
            this.Red.HeaderText = "Red";
            this.Red.Name = "Red";
            this.Red.Width = 40;
            // 
            // Green
            // 
            this.Green.HeaderText = "Green";
            this.Green.Name = "Green";
            this.Green.Width = 40;
            // 
            // Blue
            // 
            this.Blue.HeaderText = "Blue";
            this.Blue.Name = "Blue";
            this.Blue.Width = 40;
            // 
            // dataGridView_meu_sigma
            // 
            this.dataGridView_meu_sigma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_meu_sigma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MeuR,
            this.SigmaR,
            this.MeuG,
            this.SigmaG,
            this.MeuB,
            this.SigmaB});
            this.dataGridView_meu_sigma.Location = new System.Drawing.Point(0, 211);
            this.dataGridView_meu_sigma.Name = "dataGridView_meu_sigma";
            this.dataGridView_meu_sigma.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_meu_sigma.TabIndex = 3;
            // 
            // button_create_class_from_sample
            // 
            this.button_create_class_from_sample.Location = new System.Drawing.Point(0, 182);
            this.button_create_class_from_sample.Name = "button_create_class_from_sample";
            this.button_create_class_from_sample.Size = new System.Drawing.Size(240, 23);
            this.button_create_class_from_sample.TabIndex = 4;
            this.button_create_class_from_sample.Text = "Create Class from Sample";
            this.button_create_class_from_sample.UseVisualStyleBackColor = true;
            this.button_create_class_from_sample.Click += new System.EventHandler(this.button_create_class_from_sample_Click);
            // 
            // MeuR
            // 
            this.MeuR.HeaderText = "Meu R";
            this.MeuR.Name = "MeuR";
            this.MeuR.Width = 30;
            // 
            // SigmaR
            // 
            this.SigmaR.HeaderText = "Sigma R";
            this.SigmaR.Name = "SigmaR";
            this.SigmaR.Width = 40;
            // 
            // MeuG
            // 
            this.MeuG.HeaderText = "Meu G";
            this.MeuG.Name = "MeuG";
            this.MeuG.Width = 30;
            // 
            // SigmaG
            // 
            this.SigmaG.HeaderText = "Sigma G";
            this.SigmaG.Name = "SigmaG";
            this.SigmaG.Width = 40;
            // 
            // MeuB
            // 
            this.MeuB.HeaderText = "Meu B";
            this.MeuB.Name = "MeuB";
            this.MeuB.Width = 30;
            // 
            // SigmaB
            // 
            this.SigmaB.HeaderText = "Sigma B";
            this.SigmaB.Name = "SigmaB";
            this.SigmaB.Width = 40;
            // 
            // button_render
            // 
            this.button_render.Location = new System.Drawing.Point(0, 577);
            this.button_render.Name = "button_render";
            this.button_render.Size = new System.Drawing.Size(240, 23);
            this.button_render.TabIndex = 5;
            this.button_render.Text = "Render";
            this.button_render.UseVisualStyleBackColor = true;
            this.button_render.Click += new System.EventHandler(this.button_render_Click);
            // 
            // pictureBox_input
            // 
            this.pictureBox_input.Location = new System.Drawing.Point(246, 0);
            this.pictureBox_input.Name = "pictureBox_input";
            this.pictureBox_input.Size = new System.Drawing.Size(400, 600);
            this.pictureBox_input.TabIndex = 6;
            this.pictureBox_input.TabStop = false;
            this.pictureBox_input.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_input_MouseClick);
            // 
            // pictureBox_output
            // 
            this.pictureBox_output.Location = new System.Drawing.Point(652, 0);
            this.pictureBox_output.Name = "pictureBox_output";
            this.pictureBox_output.Size = new System.Drawing.Size(400, 600);
            this.pictureBox_output.TabIndex = 6;
            this.pictureBox_output.TabStop = false;
            // 
            // dataGridView_loss_function
            // 
            this.dataGridView_loss_function.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_loss_function.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actions});
            this.dataGridView_loss_function.Location = new System.Drawing.Point(0, 380);
            this.dataGridView_loss_function.Name = "dataGridView_loss_function";
            this.dataGridView_loss_function.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_loss_function.TabIndex = 3;
            // 
            // label_loss_function
            // 
            this.label_loss_function.AutoSize = true;
            this.label_loss_function.Location = new System.Drawing.Point(12, 364);
            this.label_loss_function.Name = "label_loss_function";
            this.label_loss_function.Size = new System.Drawing.Size(76, 13);
            this.label_loss_function.TabIndex = 7;
            this.label_loss_function.Text = "Loss Function:";
            // 
            // actions
            // 
            this.actions.HeaderText = "";
            this.actions.Name = "actions";
            this.actions.Width = 30;
            // 
            // Form_Task_3_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 657);
            this.Controls.Add(this.label_loss_function);
            this.Controls.Add(this.pictureBox_output);
            this.Controls.Add(this.button_render);
            this.Controls.Add(this.button_create_class_from_sample);
            this.Controls.Add(this.dataGridView_loss_function);
            this.Controls.Add(this.dataGridView_meu_sigma);
            this.Controls.Add(this.dataGridView_samples);
            this.Controls.Add(this.button_load_image_file);
            this.Controls.Add(this.textBox_file_path);
            this.Controls.Add(this.pictureBox_input);
            this.Name = "Form_Task_3_a";
            this.Text = "Task 3 Load Image";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_samples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_meu_sigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_loss_function)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_file_path;
        private System.Windows.Forms.Button button_load_image_file;
        private System.Windows.Forms.DataGridView dataGridView_samples;
        private System.Windows.Forms.DataGridViewTextBoxColumn Red;
        private System.Windows.Forms.DataGridViewTextBoxColumn Green;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blue;
        private System.Windows.Forms.DataGridView dataGridView_meu_sigma;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeuR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SigmaR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeuG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SigmaG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeuB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SigmaB;
        private System.Windows.Forms.Button button_create_class_from_sample;
        private System.Windows.Forms.Button button_render;
        private System.Windows.Forms.PictureBox pictureBox_input;
        private System.Windows.Forms.PictureBox pictureBox_output;
        private System.Windows.Forms.DataGridView dataGridView_loss_function;
        private System.Windows.Forms.Label label_loss_function;
        private System.Windows.Forms.DataGridViewTextBoxColumn actions;
    }
}