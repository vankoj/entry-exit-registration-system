
namespace Entry_Exit_Registration_System
{
    partial class Form_AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AdminLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_username = new RoundTextBoxExample.CeLearningTextbox();
            this.textBox_passowrd = new RoundTextBoxExample.CeLearningTextbox();
            this.login_button = new GroceryShop.CustomBtn.RoundButton();
            this.username_lable = new System.Windows.Forms.Label();
            this.passowrd_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Entry_Exit_Registration_System.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.Color.Transparent;
            this.textBox_username.BorderColor = System.Drawing.Color.Gray;
            this.textBox_username.BorderSize = 1;
            this.textBox_username.Br = System.Drawing.Color.Cornsilk;
            this.textBox_username.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_username.ForeColor = System.Drawing.Color.Black;
            this.textBox_username.Location = new System.Drawing.Point(98, 60);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.PasswordChar = '\0';
            this.textBox_username.Size = new System.Drawing.Size(287, 33);
            this.textBox_username.TabIndex = 0;
            this.textBox_username.textboxRadius = 15;
            this.textBox_username.UseSystemPasswordChar = false;
            // 
            // textBox_passowrd
            // 
            this.textBox_passowrd.BackColor = System.Drawing.Color.Transparent;
            this.textBox_passowrd.BorderColor = System.Drawing.Color.Gray;
            this.textBox_passowrd.BorderSize = 1;
            this.textBox_passowrd.Br = System.Drawing.Color.Cornsilk;
            this.textBox_passowrd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_passowrd.ForeColor = System.Drawing.Color.Black;
            this.textBox_passowrd.Location = new System.Drawing.Point(98, 147);
            this.textBox_passowrd.Name = "textBox_passowrd";
            this.textBox_passowrd.PasswordChar = '●';
            this.textBox_passowrd.Size = new System.Drawing.Size(287, 33);
            this.textBox_passowrd.TabIndex = 1;
            this.textBox_passowrd.textboxRadius = 15;
            this.textBox_passowrd.UseSystemPasswordChar = true;
            // 
            // login_button
            // 
            this.login_button.BorderColor = System.Drawing.Color.Silver;
            this.login_button.ButtonColor = System.Drawing.Color.Cornsilk;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.Location = new System.Drawing.Point(326, 199);
            this.login_button.Name = "login_button";
            this.login_button.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.login_button.OnHoverButtonColor = System.Drawing.Color.SeaGreen;
            this.login_button.OnHoverTextColor = System.Drawing.Color.Black;
            this.login_button.Size = new System.Drawing.Size(85, 33);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "login";
            this.login_button.TextColor = System.Drawing.Color.Black;
            this.login_button.UseVisualStyleBackColor = true;
            // 
            // username_lable
            // 
            this.username_lable.AutoSize = true;
            this.username_lable.Location = new System.Drawing.Point(95, 24);
            this.username_lable.Name = "username_lable";
            this.username_lable.Size = new System.Drawing.Size(109, 17);
            this.username_lable.TabIndex = 7;
            this.username_lable.Text = "username_lable";
            // 
            // passowrd_label
            // 
            this.passowrd_label.AutoSize = true;
            this.passowrd_label.Location = new System.Drawing.Point(95, 115);
            this.passowrd_label.Name = "passowrd_label";
            this.passowrd_label.Size = new System.Drawing.Size(106, 17);
            this.passowrd_label.TabIndex = 8;
            this.passowrd_label.Text = "passowrd_label";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Entry_Exit_Registration_System.Properties.Resources.padlock;
            this.pictureBox2.Location = new System.Drawing.Point(12, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form_AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(423, 256);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.passowrd_label);
            this.Controls.Add(this.username_lable);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.textBox_passowrd);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_AdminLogin";
            this.Text = "Form_AdminLogin";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundTextBoxExample.CeLearningTextbox textBox_username;
        private RoundTextBoxExample.CeLearningTextbox textBox_passowrd;
        private GroceryShop.CustomBtn.RoundButton login_button;
        private System.Windows.Forms.Label username_lable;
        private System.Windows.Forms.Label passowrd_label;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}