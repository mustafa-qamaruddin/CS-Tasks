namespace Patterns_Recognition___Task_1
{
    partial class Form_Task_3_b
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
            this.button_load_test_case = new System.Windows.Forms.Button();
            this.dataGridView_meus_sigmas = new System.Windows.Forms.DataGridView();
            this.MeuRed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SigmaRed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeuGreen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SigmaGreen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeuBlue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SigmaBlue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_loss_function = new System.Windows.Forms.DataGridView();
            this.actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_render = new System.Windows.Forms.Button();
            this.pictureBox_generated = new System.Windows.Forms.PictureBox();
            this.label_height = new System.Windows.Forms.Label();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.label_width = new System.Windows.Forms.Label();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.pictureBox_test_generated = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_meus_sigmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_loss_function)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_generated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_test_generated)).BeginInit();
            this.SuspendLayout();
            // 
            // button_load_test_case
            // 
            this.button_load_test_case.Location = new System.Drawing.Point(0, 0);
            this.button_load_test_case.Name = "button_load_test_case";
            this.button_load_test_case.Size = new System.Drawing.Size(253, 23);
            this.button_load_test_case.TabIndex = 0;
            this.button_load_test_case.Text = "Load Test Case";
            this.button_load_test_case.UseVisualStyleBackColor = true;
            this.button_load_test_case.Click += new System.EventHandler(this.button_load_test_case_Click);
            // 
            // dataGridView_meus_sigmas
            // 
            this.dataGridView_meus_sigmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_meus_sigmas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MeuRed,
            this.SigmaRed,
            this.MeuGreen,
            this.SigmaGreen,
            this.MeuBlue,
            this.SigmaBlue,
            this.Priori});
            this.dataGridView_meus_sigmas.Location = new System.Drawing.Point(0, 29);
            this.dataGridView_meus_sigmas.Name = "dataGridView_meus_sigmas";
            this.dataGridView_meus_sigmas.Size = new System.Drawing.Size(253, 150);
            this.dataGridView_meus_sigmas.TabIndex = 1;
            this.dataGridView_meus_sigmas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_meus_sigmas_RowsAdded);
            // 
            // MeuRed
            // 
            this.MeuRed.HeaderText = "Meu Red";
            this.MeuRed.Name = "MeuRed";
            this.MeuRed.Width = 30;
            // 
            // SigmaRed
            // 
            this.SigmaRed.HeaderText = "Sigma Red";
            this.SigmaRed.Name = "SigmaRed";
            this.SigmaRed.Width = 40;
            // 
            // MeuGreen
            // 
            this.MeuGreen.HeaderText = "Meu Green";
            this.MeuGreen.Name = "MeuGreen";
            this.MeuGreen.Width = 30;
            // 
            // SigmaGreen
            // 
            this.SigmaGreen.HeaderText = "Sigma Green";
            this.SigmaGreen.Name = "SigmaGreen";
            this.SigmaGreen.Width = 40;
            // 
            // MeuBlue
            // 
            this.MeuBlue.HeaderText = "Meu Blue";
            this.MeuBlue.Name = "MeuBlue";
            this.MeuBlue.Width = 30;
            // 
            // SigmaBlue
            // 
            this.SigmaBlue.HeaderText = "Sigma Blue";
            this.SigmaBlue.Name = "SigmaBlue";
            this.SigmaBlue.Width = 40;
            // 
            // Priori
            // 
            this.Priori.HeaderText = "Priori";
            this.Priori.Name = "Priori";
            this.Priori.Width = 30;
            // 
            // dataGridView_loss_function
            // 
            this.dataGridView_loss_function.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_loss_function.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actions});
            this.dataGridView_loss_function.Location = new System.Drawing.Point(0, 185);
            this.dataGridView_loss_function.Name = "dataGridView_loss_function";
            this.dataGridView_loss_function.Size = new System.Drawing.Size(253, 150);
            this.dataGridView_loss_function.TabIndex = 4;
            // 
            // actions
            // 
            this.actions.HeaderText = "";
            this.actions.Name = "actions";
            this.actions.Width = 30;
            // 
            // button_render
            // 
            this.button_render.Location = new System.Drawing.Point(0, 364);
            this.button_render.Name = "button_render";
            this.button_render.Size = new System.Drawing.Size(253, 23);
            this.button_render.TabIndex = 5;
            this.button_render.Text = "Render";
            this.button_render.UseVisualStyleBackColor = true;
            this.button_render.Click += new System.EventHandler(this.button_render_Click);
            // 
            // pictureBox_generated
            // 
            this.pictureBox_generated.Location = new System.Drawing.Point(259, 0);
            this.pictureBox_generated.Name = "pictureBox_generated";
            this.pictureBox_generated.Size = new System.Drawing.Size(800, 650);
            this.pictureBox_generated.TabIndex = 6;
            this.pictureBox_generated.TabStop = false;
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(155, 341);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(38, 13);
            this.label_height.TabIndex = 7;
            this.label_height.Text = "Height";
            this.label_height.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(193, 338);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(60, 20);
            this.textBox_height.TabIndex = 8;
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(1, 341);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(35, 13);
            this.label_width.TabIndex = 7;
            this.label_width.Text = "Width";
            this.label_width.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(39, 338);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(60, 20);
            this.textBox_width.TabIndex = 8;
            // 
            // pictureBox_test_generated
            // 
            this.pictureBox_test_generated.Location = new System.Drawing.Point(0, 393);
            this.pictureBox_test_generated.Name = "pictureBox_test_generated";
            this.pictureBox_test_generated.Size = new System.Drawing.Size(253, 257);
            this.pictureBox_test_generated.TabIndex = 9;
            this.pictureBox_test_generated.TabStop = false;
            // 
            // Form_Task_3_b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 657);
            this.Controls.Add(this.pictureBox_test_generated);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.label_width);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.pictureBox_generated);
            this.Controls.Add(this.button_render);
            this.Controls.Add(this.dataGridView_loss_function);
            this.Controls.Add(this.dataGridView_meus_sigmas);
            this.Controls.Add(this.button_load_test_case);
            this.Name = "Form_Task_3_b";
            this.Text = "Generate Image";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_meus_sigmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_loss_function)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_generated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_test_generated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_load_test_case;
        private System.Windows.Forms.DataGridView dataGridView_meus_sigmas;
        private System.Windows.Forms.DataGridView dataGridView_loss_function;
        private System.Windows.Forms.DataGridViewTextBoxColumn actions;
        private System.Windows.Forms.Button button_render;
        private System.Windows.Forms.PictureBox pictureBox_generated;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeuRed;
        private System.Windows.Forms.DataGridViewTextBoxColumn SigmaRed;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeuGreen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SigmaGreen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeuBlue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SigmaBlue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priori;
        private System.Windows.Forms.PictureBox pictureBox_test_generated;
    }
}