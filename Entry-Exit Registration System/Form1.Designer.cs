
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.top_lable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_checking = new RoundTextBoxExample.CeLearningTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.check_button = new GroceryShop.CustomBtn.RoundButton();
            this.input_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.textBox_checking);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.check_button);
            this.panel1.Controls.Add(this.input_label);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-4, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 218);
            this.panel1.TabIndex = 4;
            // 
            // textBox_checking
            // 
            this.textBox_checking.BackColor = System.Drawing.Color.Transparent;
            this.textBox_checking.BorderColor = System.Drawing.Color.Gray;
            this.textBox_checking.BorderSize = 1;
            this.textBox_checking.Br = System.Drawing.Color.Cornsilk;
            this.textBox_checking.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_checking.ForeColor = System.Drawing.Color.Black;
            this.textBox_checking.Location = new System.Drawing.Point(117, 112);
            this.textBox_checking.Name = "textBox_checking";
            this.textBox_checking.PasswordChar = '●';
            this.textBox_checking.Size = new System.Drawing.Size(223, 37);
            this.textBox_checking.TabIndex = 5;
            this.textBox_checking.textboxRadius = 15;
            this.textBox_checking.UseSystemPasswordChar = true;
            this.textBox_checking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_checking_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Entry_Exit_Registration_System.Properties.Resources.user;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(41, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // check_button
            // 
            this.check_button.BorderColor = System.Drawing.Color.Silver;
            this.check_button.ButtonColor = System.Drawing.Color.Cornsilk;
            this.check_button.FlatAppearance.BorderSize = 0;
            this.check_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.check_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.check_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_button.Location = new System.Drawing.Point(357, 112);
            this.check_button.Name = "check_button";
            this.check_button.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.check_button.OnHoverButtonColor = System.Drawing.Color.SeaGreen;
            this.check_button.OnHoverTextColor = System.Drawing.Color.Black;
            this.check_button.Size = new System.Drawing.Size(124, 37);
            this.check_button.TabIndex = 3;
            this.check_button.Text = "check_button";
            this.check_button.TextColor = System.Drawing.Color.Black;
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Location = new System.Drawing.Point(114, 56);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(77, 17);
            this.input_label.TabIndex = 2;
            this.input_label.Text = "input_label";
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label top_lable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label input_label;
        private GroceryShop.CustomBtn.RoundButton check_button;
        private RoundTextBoxExample.CeLearningTextbox textBox_checking;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

