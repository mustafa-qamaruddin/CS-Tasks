namespace Patterns_Recognition___Task_1
{
    partial class Form_Task_1
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
            this.picture_box_pr = new System.Windows.Forms.PictureBox();
            this.text_box_pr_img_src = new System.Windows.Forms.TextBox();
            this.button_pr_load_img_file = new System.Windows.Forms.Button();
            this.button_open_test_normal_distribution_form = new System.Windows.Forms.Button();
            this.button_split_paint_rects = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_pr)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_box_pr
            // 
            this.picture_box_pr.Location = new System.Drawing.Point(12, 38);
            this.picture_box_pr.Name = "picture_box_pr";
            this.picture_box_pr.Size = new System.Drawing.Size(640, 480);
            this.picture_box_pr.TabIndex = 0;
            this.picture_box_pr.TabStop = false;
            // 
            // text_box_pr_img_src
            // 
            this.text_box_pr_img_src.Location = new System.Drawing.Point(12, 12);
            this.text_box_pr_img_src.Name = "text_box_pr_img_src";
            this.text_box_pr_img_src.Size = new System.Drawing.Size(507, 20);
            this.text_box_pr_img_src.TabIndex = 1;
            // 
            // button_pr_load_img_file
            // 
            this.button_pr_load_img_file.Location = new System.Drawing.Point(525, 12);
            this.button_pr_load_img_file.Name = "button_pr_load_img_file";
            this.button_pr_load_img_file.Size = new System.Drawing.Size(127, 20);
            this.button_pr_load_img_file.TabIndex = 2;
            this.button_pr_load_img_file.Text = "Load Image File";
            this.button_pr_load_img_file.UseVisualStyleBackColor = true;
            this.button_pr_load_img_file.Click += new System.EventHandler(this.button_pr_load_img_file_Click);
            // 
            // button_open_test_normal_distribution_form
            // 
            this.button_open_test_normal_distribution_form.Location = new System.Drawing.Point(658, 12);
            this.button_open_test_normal_distribution_form.Name = "button_open_test_normal_distribution_form";
            this.button_open_test_normal_distribution_form.Size = new System.Drawing.Size(130, 23);
            this.button_open_test_normal_distribution_form.TabIndex = 3;
            this.button_open_test_normal_distribution_form.Text = "Test Normal Distribution";
            this.button_open_test_normal_distribution_form.UseVisualStyleBackColor = true;
            this.button_open_test_normal_distribution_form.Click += new System.EventHandler(this.button_open_test_normal_distribution_form_Click);
            // 
            // button_split_paint_rects
            // 
            this.button_split_paint_rects.Location = new System.Drawing.Point(658, 38);
            this.button_split_paint_rects.Name = "button_split_paint_rects";
            this.button_split_paint_rects.Size = new System.Drawing.Size(130, 23);
            this.button_split_paint_rects.TabIndex = 3;
            this.button_split_paint_rects.Text = "Split & Paint Rectangles";
            this.button_split_paint_rects.UseVisualStyleBackColor = true;
            this.button_split_paint_rects.Click += new System.EventHandler(this.button_split_paint_rects_Click);
            // 
            // Form_Task_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.button_split_paint_rects);
            this.Controls.Add(this.button_open_test_normal_distribution_form);
            this.Controls.Add(this.button_pr_load_img_file);
            this.Controls.Add(this.text_box_pr_img_src);
            this.Controls.Add(this.picture_box_pr);
            this.Name = "Form_Task_1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_pr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_box_pr;
        private System.Windows.Forms.TextBox text_box_pr_img_src;
        private System.Windows.Forms.Button button_pr_load_img_file;
        private System.Windows.Forms.Button button_open_test_normal_distribution_form;
        private System.Windows.Forms.Button button_split_paint_rects;
    }
}

