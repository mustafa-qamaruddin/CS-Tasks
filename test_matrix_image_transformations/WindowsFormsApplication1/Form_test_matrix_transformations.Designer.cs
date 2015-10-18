namespace TestMatrixTransformations
{
    partial class Form_test_matrix_transformations
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_test_matrix_transformations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(795, 536);
            this.textBox1.TabIndex = 0;
            // 
            // button_test_matrix_transformations
            // 
            this.button_test_matrix_transformations.Location = new System.Drawing.Point(603, 542);
            this.button_test_matrix_transformations.Name = "button_test_matrix_transformations";
            this.button_test_matrix_transformations.Size = new System.Drawing.Size(177, 23);
            this.button_test_matrix_transformations.TabIndex = 1;
            this.button_test_matrix_transformations.Text = "Test Matrix Transformations";
            this.button_test_matrix_transformations.UseVisualStyleBackColor = true;
            this.button_test_matrix_transformations.Click += new System.EventHandler(this.button_test_matrix_transformations_Click);
            // 
            // Form_test_matrix_transformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.button_test_matrix_transformations);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_test_matrix_transformations";
            this.Text = "Test Matrix Transofrmations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_test_matrix_transformations;
    }
}

