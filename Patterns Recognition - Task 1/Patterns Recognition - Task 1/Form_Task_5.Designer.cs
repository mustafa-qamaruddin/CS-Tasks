namespace Patterns_Recognition___Task_1
{
    partial class Form_Task_5
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
            this.label_overall_accuracy = new System.Windows.Forms.Label();
            this.label_confusion_matrix = new System.Windows.Forms.Label();
            this.dataGridView_confusion_matrix = new System.Windows.Forms.DataGridView();
            this.button_load_data_set = new System.Windows.Forms.Button();
            this.textBox_overall_accuracy = new System.Windows.Forms.TextBox();
            this.textBox_file_path = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_confusion_matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label_overall_accuracy
            // 
            this.label_overall_accuracy.AutoSize = true;
            this.label_overall_accuracy.Location = new System.Drawing.Point(21, 211);
            this.label_overall_accuracy.Name = "label_overall_accuracy";
            this.label_overall_accuracy.Size = new System.Drawing.Size(88, 13);
            this.label_overall_accuracy.TabIndex = 10;
            this.label_overall_accuracy.Text = "Overall Accuracy";
            this.label_overall_accuracy.Click += new System.EventHandler(this.label_overall_accuracy_Click);
            // 
            // label_confusion_matrix
            // 
            this.label_confusion_matrix.AutoSize = true;
            this.label_confusion_matrix.Location = new System.Drawing.Point(24, 36);
            this.label_confusion_matrix.Name = "label_confusion_matrix";
            this.label_confusion_matrix.Size = new System.Drawing.Size(85, 13);
            this.label_confusion_matrix.TabIndex = 9;
            this.label_confusion_matrix.Text = "Confusion Matrix";
            this.label_confusion_matrix.Click += new System.EventHandler(this.label_confusion_matrix_Click);
            // 
            // dataGridView_confusion_matrix
            // 
            this.dataGridView_confusion_matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_confusion_matrix.Location = new System.Drawing.Point(12, 52);
            this.dataGridView_confusion_matrix.Name = "dataGridView_confusion_matrix";
            this.dataGridView_confusion_matrix.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_confusion_matrix.TabIndex = 8;
            this.dataGridView_confusion_matrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_confusion_matrix_CellContentClick);
            // 
            // button_load_data_set
            // 
            this.button_load_data_set.Location = new System.Drawing.Point(142, 13);
            this.button_load_data_set.Name = "button_load_data_set";
            this.button_load_data_set.Size = new System.Drawing.Size(110, 20);
            this.button_load_data_set.TabIndex = 7;
            this.button_load_data_set.Text = "Load Data Set";
            this.button_load_data_set.UseVisualStyleBackColor = true;
            this.button_load_data_set.Click += new System.EventHandler(this.button_load_data_set_Click);
            // 
            // textBox_overall_accuracy
            // 
            this.textBox_overall_accuracy.Location = new System.Drawing.Point(115, 208);
            this.textBox_overall_accuracy.Name = "textBox_overall_accuracy";
            this.textBox_overall_accuracy.Size = new System.Drawing.Size(137, 20);
            this.textBox_overall_accuracy.TabIndex = 5;
            this.textBox_overall_accuracy.TextChanged += new System.EventHandler(this.textBox_overall_accuracy_TextChanged);
            // 
            // textBox_file_path
            // 
            this.textBox_file_path.Location = new System.Drawing.Point(12, 13);
            this.textBox_file_path.Name = "textBox_file_path";
            this.textBox_file_path.Size = new System.Drawing.Size(124, 20);
            this.textBox_file_path.TabIndex = 6;
            this.textBox_file_path.TextChanged += new System.EventHandler(this.textBox_file_path_TextChanged);
            // 
            // Form_Task_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 352);
            this.Controls.Add(this.label_overall_accuracy);
            this.Controls.Add(this.label_confusion_matrix);
            this.Controls.Add(this.dataGridView_confusion_matrix);
            this.Controls.Add(this.button_load_data_set);
            this.Controls.Add(this.textBox_overall_accuracy);
            this.Controls.Add(this.textBox_file_path);
            this.Name = "Form_Task_5";
            this.Text = "Form_Task_5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_confusion_matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_overall_accuracy;
        private System.Windows.Forms.Label label_confusion_matrix;
        private System.Windows.Forms.DataGridView dataGridView_confusion_matrix;
        private System.Windows.Forms.Button button_load_data_set;
        private System.Windows.Forms.TextBox textBox_overall_accuracy;
        private System.Windows.Forms.TextBox textBox_file_path;
    }
}