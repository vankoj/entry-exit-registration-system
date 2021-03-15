
namespace Entry_Exit_Registration_System
{
    partial class Form1
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
            this.top_lable = new System.Windows.Forms.Label();
            this.input_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_checking = new System.Windows.Forms.TextBox();
            this.check_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_lable
            // 
            this.top_lable.BackColor = System.Drawing.Color.SeaGreen;
            this.top_lable.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_lable.Location = new System.Drawing.Point(0, 0);
            this.top_lable.Name = "top_lable";
            this.top_lable.Size = new System.Drawing.Size(515, 68);
            this.top_lable.TabIndex = 0;
            this.top_lable.Text = "top_lable";
            this.top_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Location = new System.Drawing.Point(64, 76);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(77, 17);
            this.input_label.TabIndex = 1;
            this.input_label.Text = "input_label";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_checking);
            this.panel1.Controls.Add(this.input_label);
            this.panel1.Controls.Add(this.check_button);
            this.panel1.Location = new System.Drawing.Point(3, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 208);
            this.panel1.TabIndex = 4;
            // 
            // textBox_checking
            // 
            this.textBox_checking.Location = new System.Drawing.Point(67, 123);
            this.textBox_checking.Name = "textBox_checking";
            this.textBox_checking.Size = new System.Drawing.Size(273, 22);
            this.textBox_checking.TabIndex = 2;
            this.textBox_checking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_checking_KeyPress);
            // 
            // check_button
            // 
            this.check_button.Location = new System.Drawing.Point(346, 121);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(98, 27);
            this.check_button.TabIndex = 0;
            this.check_button.Text = "check_button";
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(515, 291);
            this.Controls.Add(this.top_lable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label top_lable;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.TextBox textBox_checking;
    }
}

