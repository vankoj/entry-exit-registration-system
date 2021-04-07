
namespace Entry_Exit_Registration_System
{
    partial class Form_Cheking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cheking));
            this.top_lable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_checking = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.check_button = new GroceryShop.CustomBtn.RoundButton();
            this.input_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.windowName = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // top_lable
            // 
            this.top_lable.BackColor = System.Drawing.Color.SeaGreen;
            this.top_lable.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_lable.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.top_lable.Location = new System.Drawing.Point(0, 0);
            this.top_lable.Name = "top_lable";
            this.top_lable.Size = new System.Drawing.Size(515, 68);
            this.top_lable.TabIndex = 0;
            this.top_lable.Text = "top_lable";
            this.top_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.top_lable.Click += new System.EventHandler(this.top_lable_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.top_lable);
            this.panel2.Controls.Add(this.textBox_checking);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.check_button);
            this.panel2.Controls.Add(this.input_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 250);
            this.panel2.TabIndex = 4;
            // 
            // textBox_checking
            // 
            this.textBox_checking.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox_checking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_checking.Location = new System.Drawing.Point(120, 173);
            this.textBox_checking.Name = "textBox_checking";
            this.textBox_checking.Size = new System.Drawing.Size(223, 36);
            this.textBox_checking.TabIndex = 5;
            this.textBox_checking.UseSystemPasswordChar = true;
            this.textBox_checking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_checking_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Entry_Exit_Registration_System.Properties.Resources.user;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(43, 159);
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
            this.check_button.Location = new System.Drawing.Point(360, 173);
            this.check_button.Name = "check_button";
            this.check_button.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.check_button.OnHoverButtonColor = System.Drawing.Color.SeaGreen;
            this.check_button.OnHoverTextColor = System.Drawing.Color.Black;
            this.check_button.Size = new System.Drawing.Size(124, 36);
            this.check_button.TabIndex = 2;
            this.check_button.Text = "check_button";
            this.check_button.TextColor = System.Drawing.Color.Black;
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_label.Location = new System.Drawing.Point(117, 117);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(112, 26);
            this.input_label.TabIndex = 2;
            this.input_label.Text = "input_label";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.windowName);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 40);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = global::Entry_Exit_Registration_System.Properties.Resources.minimize;
            this.minimizeButton.Location = new System.Drawing.Point(442, 4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(32, 32);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeButton.TabIndex = 5;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::Entry_Exit_Registration_System.Properties.Resources.id_card;
            this.logo.Location = new System.Drawing.Point(3, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(32, 32);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // windowName
            // 
            this.windowName.AutoSize = true;
            this.windowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windowName.Location = new System.Drawing.Point(41, 7);
            this.windowName.Name = "windowName";
            this.windowName.Size = new System.Drawing.Size(161, 29);
            this.windowName.TabIndex = 3;
            this.windowName.Text = "windowName";
            this.windowName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = global::Entry_Exit_Registration_System.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(480, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form_Cheking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(515, 290);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Cheking";
            this.Text = "Form_Cheking";
            this.Load += new System.EventHandler(this.Form_Cheking_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label top_lable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_checking;
        private GroceryShop.CustomBtn.RoundButton check_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label windowName;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox minimizeButton;
    }
}

