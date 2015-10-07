namespace Patterns_Recognition___Task_1
{
    partial class Form_Task_1_b
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
            this.label_width = new System.Windows.Forms.Label();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.label_height = new System.Windows.Forms.Label();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.dataGridView_Meus_Sigmas = new System.Windows.Forms.DataGridView();
            this.RMeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RSigma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GMeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GSigma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BMeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSigma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_render = new System.Windows.Forms.Button();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Meus_Sigmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(9, 524);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(35, 13);
            this.label_width.TabIndex = 0;
            this.label_width.Text = "Width";
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(50, 521);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(100, 20);
            this.textBox_width.TabIndex = 1;
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(204, 524);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(38, 13);
            this.label_height.TabIndex = 0;
            this.label_height.Text = "Height";
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(249, 521);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(100, 20);
            this.textBox_height.TabIndex = 1;
            // 
            // dataGridView_Meus_Sigmas
            // 
            this.dataGridView_Meus_Sigmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Meus_Sigmas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RMeu,
            this.RSigma,
            this.GMeu,
            this.GSigma,
            this.BMeu,
            this.BSigma});
            this.dataGridView_Meus_Sigmas.Location = new System.Drawing.Point(5, 2);
            this.dataGridView_Meus_Sigmas.Name = "dataGridView_Meus_Sigmas";
            this.dataGridView_Meus_Sigmas.Size = new System.Drawing.Size(344, 513);
            this.dataGridView_Meus_Sigmas.TabIndex = 2;
            this.dataGridView_Meus_Sigmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Meus_Sigmas_CellContentClick);
            // 
            // RMeu
            // 
            this.RMeu.HeaderText = "R Meu";
            this.RMeu.Name = "RMeu";
            this.RMeu.Width = 50;
            // 
            // RSigma
            // 
            this.RSigma.HeaderText = "R Sigma";
            this.RSigma.Name = "RSigma";
            this.RSigma.Width = 50;
            // 
            // GMeu
            // 
            this.GMeu.HeaderText = "G Meu";
            this.GMeu.Name = "GMeu";
            this.GMeu.Width = 50;
            // 
            // GSigma
            // 
            this.GSigma.HeaderText = "G Sigma";
            this.GSigma.Name = "GSigma";
            this.GSigma.Width = 50;
            // 
            // BMeu
            // 
            this.BMeu.HeaderText = "B Meu";
            this.BMeu.Name = "BMeu";
            this.BMeu.Width = 50;
            // 
            // BSigma
            // 
            this.BSigma.HeaderText = "B Sigma";
            this.BSigma.Name = "BSigma";
            this.BSigma.Width = 50;
            // 
            // button_render
            // 
            this.button_render.Location = new System.Drawing.Point(5, 547);
            this.button_render.Name = "button_render";
            this.button_render.Size = new System.Drawing.Size(344, 23);
            this.button_render.TabIndex = 3;
            this.button_render.Text = "Render";
            this.button_render.UseVisualStyleBackColor = true;
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Location = new System.Drawing.Point(355, 2);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(434, 568);
            this.pictureBox_image.TabIndex = 4;
            this.pictureBox_image.TabStop = false;
            // 
            // Form_Task_1_b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.pictureBox_image);
            this.Controls.Add(this.button_render);
            this.Controls.Add(this.dataGridView_Meus_Sigmas);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.label_width);
            this.Name = "Form_Task_1_b";
            this.Text = "Form_Task_1_b";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Meus_Sigmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.DataGridView dataGridView_Meus_Sigmas;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMeu;
        private System.Windows.Forms.DataGridViewTextBoxColumn RSigma;
        private System.Windows.Forms.DataGridViewTextBoxColumn GMeu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSigma;
        private System.Windows.Forms.DataGridViewTextBoxColumn BMeu;
        private System.Windows.Forms.DataGridViewTextBoxColumn BSigma;
        private System.Windows.Forms.Button button_render;
        private System.Windows.Forms.PictureBox pictureBox_image;
    }
}