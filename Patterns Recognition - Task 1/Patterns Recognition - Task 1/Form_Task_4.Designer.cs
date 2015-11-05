namespace Patterns_Recognition___Task_1
{
    partial class Form_Task_4
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
            this.button_load_data_set = new System.Windows.Forms.Button();
            this.dataGridView_confusion_matrix = new System.Windows.Forms.DataGridView();
            this.label_confusion_matrix = new System.Windows.Forms.Label();
            this.label_overall_accuracy = new System.Windows.Forms.Label();
            this.textBox_overall_accuracy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_confusion_matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_file_path
            // 
            this.textBox_file_path.Location = new System.Drawing.Point(0, 0);
            this.textBox_file_path.Name = "textBox_file_path";
            this.textBox_file_path.Size = new System.Drawing.Size(124, 20);
            this.textBox_file_path.TabIndex = 0;
            // 
            // button_load_data_set
            // 
            this.button_load_data_set.Location = new System.Drawing.Point(130, 0);
            this.button_load_data_set.Name = "button_load_data_set";
            this.button_load_data_set.Size = new System.Drawing.Size(110, 20);
            this.button_load_data_set.TabIndex = 1;
            this.button_load_data_set.Text = "Load Data Set";
            this.button_load_data_set.UseVisualStyleBackColor = true;
            this.button_load_data_set.Click += new System.EventHandler(this.button_load_data_set_Click);
            // 
            // dataGridView_confusion_matrix
            // 
            this.dataGridView_confusion_matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_confusion_matrix.Location = new System.Drawing.Point(0, 39);
            this.dataGridView_confusion_matrix.Name = "dataGridView_confusion_matrix";
            this.dataGridView_confusion_matrix.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_confusion_matrix.TabIndex = 2;
            // 
            // label_confusion_matrix
            // 
            this.label_confusion_matrix.AutoSize = true;
            this.label_confusion_matrix.Location = new System.Drawing.Point(12, 23);
            this.label_confusion_matrix.Name = "label_confusion_matrix";
            this.label_confusion_matrix.Size = new System.Drawing.Size(85, 13);
            this.label_confusion_matrix.TabIndex = 3;
            this.label_confusion_matrix.Text = "Confusion Matrix";
            // 
            // label_overall_accuracy
            // 
            this.label_overall_accuracy.AutoSize = true;
            this.label_overall_accuracy.Location = new System.Drawing.Point(9, 198);
            this.label_overall_accuracy.Name = "label_overall_accuracy";
            this.label_overall_accuracy.Size = new System.Drawing.Size(88, 13);
            this.label_overall_accuracy.TabIndex = 4;
            this.label_overall_accuracy.Text = "Overall Accuracy";
            // 
            // textBox_overall_accuracy
            // 
            this.textBox_overall_accuracy.Location = new System.Drawing.Point(103, 195);
            this.textBox_overall_accuracy.Name = "textBox_overall_accuracy";
            this.textBox_overall_accuracy.Size = new System.Drawing.Size(137, 20);
            this.textBox_overall_accuracy.TabIndex = 0;
            // 
            // Form_Task_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 657);
            this.Controls.Add(this.label_overall_accuracy);
            this.Controls.Add(this.label_confusion_matrix);
            this.Controls.Add(this.dataGridView_confusion_matrix);
            this.Controls.Add(this.button_load_data_set);
            this.Controls.Add(this.textBox_overall_accuracy);
            this.Controls.Add(this.textBox_file_path);
            this.Name = "Form_Task_4";
            this.Text = "Iris Data Set";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_confusion_matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_file_path;
        private System.Windows.Forms.Button button_load_data_set;
        private System.Windows.Forms.DataGridView dataGridView_confusion_matrix;
        private System.Windows.Forms.Label label_confusion_matrix;
        private System.Windows.Forms.Label label_overall_accuracy;
        private System.Windows.Forms.TextBox textBox_overall_accuracy;
    }
}