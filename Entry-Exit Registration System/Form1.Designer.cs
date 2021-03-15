
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
            this.input_label = new System.Windows.Forms.Label();
            this.textBox_checking = new System.Windows.Forms.TextBox();
            this.check_button = new GroceryShop.CustomBtn.RoundButton();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.check_button);
            this.panel1.Controls.Add(this.input_label);
            this.panel1.Controls.Add(this.textBox_checking);
            this.panel1.Location = new System.Drawing.Point(-4, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 218);
            this.panel1.TabIndex = 4;
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Location = new System.Drawing.Point(97, 48);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(77, 17);
            this.input_label.TabIndex = 2;
            this.input_label.Text = "input_label";
            // 
            // textBox_checking
            // 
            this.textBox_checking.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox_checking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_checking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_checking.Location = new System.Drawing.Point(100, 110);
            this.textBox_checking.Name = "textBox_checking";
            this.textBox_checking.Size = new System.Drawing.Size(212, 27);
            this.textBox_checking.TabIndex = 1;
            this.textBox_checking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_checking_KeyPress);
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
            this.check_button.Location = new System.Drawing.Point(351, 104);
            this.check_button.Name = "check_button";
            this.check_button.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.check_button.OnHoverButtonColor = System.Drawing.Color.SeaGreen;
            this.check_button.OnHoverTextColor = System.Drawing.Color.Black;
            this.check_button.Size = new System.Drawing.Size(124, 37);
            this.check_button.TabIndex = 3;
            this.check_button.Text = "check_button";
            this.check_button.TextColor = System.Drawing.Color.Black;
            this.check_button.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label top_lable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_checking;
        private System.Windows.Forms.Label input_label;
        private GroceryShop.CustomBtn.RoundButton check_button;
    }
}

