
namespace Entry_Exit_Registration_System
{
    partial class UserControl_Hire
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_f_name = new System.Windows.Forms.TextBox();
            this.f_name = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.textBox_l_name = new System.Windows.Forms.TextBox();
            this.egn = new System.Windows.Forms.Label();
            this.textBox_egn = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.Label();
            this.comboBox_position = new System.Windows.Forms.ComboBox();
            this.textBox_position_name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position_name = new System.Windows.Forms.Label();
            this.position_lable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employee_exist = new System.Windows.Forms.Label();
            this.employee_lable = new System.Windows.Forms.Label();
            this.hire_button = new GroceryShop.CustomBtn.RoundButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add_position_button = new GroceryShop.CustomBtn.RoundButton();
            this.timer_exist_lable = new System.Windows.Forms.Timer(this.components);
            this.position_exist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_f_name
            // 
            this.textBox_f_name.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox_f_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_f_name.Location = new System.Drawing.Point(40, 130);
            this.textBox_f_name.Name = "textBox_f_name";
            this.textBox_f_name.Size = new System.Drawing.Size(140, 30);
            this.textBox_f_name.TabIndex = 0;
            this.textBox_f_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_f_name_KeyPress);
            // 
            // f_name
            // 
            this.f_name.AutoSize = true;
            this.f_name.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.f_name.Location = new System.Drawing.Point(35, 101);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(77, 26);
            this.f_name.TabIndex = 1;
            this.f_name.Text = "f_name";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.l_name.Location = new System.Drawing.Point(255, 101);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(77, 26);
            this.l_name.TabIndex = 3;
            this.l_name.Text = "l_name";
            // 
            // textBox_l_name
            // 
            this.textBox_l_name.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox_l_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_l_name.Location = new System.Drawing.Point(260, 130);
            this.textBox_l_name.Name = "textBox_l_name";
            this.textBox_l_name.Size = new System.Drawing.Size(140, 30);
            this.textBox_l_name.TabIndex = 2;
            this.textBox_l_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_l_name_KeyPress);
            // 
            // egn
            // 
            this.egn.AutoSize = true;
            this.egn.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.egn.Location = new System.Drawing.Point(35, 177);
            this.egn.Name = "egn";
            this.egn.Size = new System.Drawing.Size(43, 26);
            this.egn.TabIndex = 5;
            this.egn.Text = "egn";
            // 
            // textBox_egn
            // 
            this.textBox_egn.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox_egn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_egn.Location = new System.Drawing.Point(40, 210);
            this.textBox_egn.Name = "textBox_egn";
            this.textBox_egn.Size = new System.Drawing.Size(140, 30);
            this.textBox_egn.TabIndex = 4;
            this.textBox_egn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_egn_KeyPress);
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.position.Location = new System.Drawing.Point(255, 177);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(81, 26);
            this.position.TabIndex = 6;
            this.position.Text = "position";
            // 
            // comboBox_position
            // 
            this.comboBox_position.BackColor = System.Drawing.Color.Cornsilk;
            this.comboBox_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_position.FormattingEnabled = true;
            this.comboBox_position.Location = new System.Drawing.Point(260, 210);
            this.comboBox_position.Name = "comboBox_position";
            this.comboBox_position.Size = new System.Drawing.Size(140, 30);
            this.comboBox_position.TabIndex = 7;
            this.comboBox_position.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_position_KeyPress);
            // 
            // textBox_position_name
            // 
            this.textBox_position_name.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox_position_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_position_name.Location = new System.Drawing.Point(40, 130);
            this.textBox_position_name.Name = "textBox_position_name";
            this.textBox_position_name.Size = new System.Drawing.Size(140, 30);
            this.textBox_position_name.TabIndex = 8;
            this.textBox_position_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_position_name_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(67, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(335, 110);
            this.dataGridView1.TabIndex = 11;
            // 
            // number
            // 
            this.number.Frozen = true;
            this.number.HeaderText = "№";
            this.number.MinimumWidth = 35;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 35;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Име";
            this.name.MinimumWidth = 170;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 170;
            // 
            // position_name
            // 
            this.position_name.AutoSize = true;
            this.position_name.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.position_name.Location = new System.Drawing.Point(35, 101);
            this.position_name.Name = "position_name";
            this.position_name.Size = new System.Drawing.Size(140, 26);
            this.position_name.TabIndex = 12;
            this.position_name.Text = "position_name";
            // 
            // position_lable
            // 
            this.position_lable.AutoSize = true;
            this.position_lable.Font = new System.Drawing.Font("Sylfaen", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.position_lable.Location = new System.Drawing.Point(60, 46);
            this.position_lable.Name = "position_lable";
            this.position_lable.Size = new System.Drawing.Size(179, 36);
            this.position_lable.TabIndex = 13;
            this.position_lable.Text = "position_lable";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.employee_exist);
            this.panel1.Controls.Add(this.employee_lable);
            this.panel1.Controls.Add(this.hire_button);
            this.panel1.Controls.Add(this.textBox_f_name);
            this.panel1.Controls.Add(this.f_name);
            this.panel1.Controls.Add(this.textBox_l_name);
            this.panel1.Controls.Add(this.l_name);
            this.panel1.Controls.Add(this.textBox_egn);
            this.panel1.Controls.Add(this.egn);
            this.panel1.Controls.Add(this.comboBox_position);
            this.panel1.Controls.Add(this.position);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 400);
            this.panel1.TabIndex = 14;
            // 
            // employee_exist
            // 
            this.employee_exist.AutoSize = true;
            this.employee_exist.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employee_exist.ForeColor = System.Drawing.Color.DarkRed;
            this.employee_exist.Location = new System.Drawing.Point(15, 290);
            this.employee_exist.Name = "employee_exist";
            this.employee_exist.Size = new System.Drawing.Size(183, 30);
            this.employee_exist.TabIndex = 15;
            this.employee_exist.Text = "employee_exist";
            // 
            // employee_lable
            // 
            this.employee_lable.AutoSize = true;
            this.employee_lable.Font = new System.Drawing.Font("Sylfaen", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employee_lable.Location = new System.Drawing.Point(60, 46);
            this.employee_lable.Name = "employee_lable";
            this.employee_lable.Size = new System.Drawing.Size(199, 36);
            this.employee_lable.TabIndex = 14;
            this.employee_lable.Text = "employee_lable";
            // 
            // hire_button
            // 
            this.hire_button.BorderColor = System.Drawing.Color.Silver;
            this.hire_button.ButtonColor = System.Drawing.Color.Cornsilk;
            this.hire_button.FlatAppearance.BorderSize = 0;
            this.hire_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hire_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hire_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hire_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hire_button.Location = new System.Drawing.Point(188, 350);
            this.hire_button.Name = "hire_button";
            this.hire_button.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.hire_button.OnHoverButtonColor = System.Drawing.Color.SeaGreen;
            this.hire_button.OnHoverTextColor = System.Drawing.Color.Black;
            this.hire_button.Size = new System.Drawing.Size(200, 30);
            this.hire_button.TabIndex = 9;
            this.hire_button.Text = "hire_button";
            this.hire_button.TextColor = System.Drawing.Color.Black;
            this.hire_button.UseVisualStyleBackColor = true;
            this.hire_button.Click += new System.EventHandler(this.hire_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.position_exist);
            this.panel2.Controls.Add(this.position_lable);
            this.panel2.Controls.Add(this.textBox_position_name);
            this.panel2.Controls.Add(this.position_name);
            this.panel2.Controls.Add(this.add_position_button);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(452, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 400);
            this.panel2.TabIndex = 15;
            // 
            // add_position_button
            // 
            this.add_position_button.BorderColor = System.Drawing.Color.Silver;
            this.add_position_button.ButtonColor = System.Drawing.Color.Cornsilk;
            this.add_position_button.FlatAppearance.BorderSize = 0;
            this.add_position_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add_position_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add_position_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_position_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_position_button.Location = new System.Drawing.Point(202, 350);
            this.add_position_button.Name = "add_position_button";
            this.add_position_button.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.add_position_button.OnHoverButtonColor = System.Drawing.Color.SeaGreen;
            this.add_position_button.OnHoverTextColor = System.Drawing.Color.Black;
            this.add_position_button.Size = new System.Drawing.Size(200, 30);
            this.add_position_button.TabIndex = 10;
            this.add_position_button.Text = "add_position_button";
            this.add_position_button.TextColor = System.Drawing.Color.Black;
            this.add_position_button.UseVisualStyleBackColor = true;
            this.add_position_button.Click += new System.EventHandler(this.add_position_button_Click);
            // 
            // timer_exist_lable
            // 
            this.timer_exist_lable.Tick += new System.EventHandler(this.timer_exist_lable_Tick);
            // 
            // position_exist
            // 
            this.position_exist.AutoSize = true;
            this.position_exist.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.position_exist.ForeColor = System.Drawing.Color.DarkRed;
            this.position_exist.Location = new System.Drawing.Point(15, 290);
            this.position_exist.Name = "position_exist";
            this.position_exist.Size = new System.Drawing.Size(164, 30);
            this.position_exist.TabIndex = 16;
            this.position_exist.Text = "position_exist";
            // 
            // UserControl_Hire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_Hire";
            this.Size = new System.Drawing.Size(900, 400);
            this.Load += new System.EventHandler(this.UserControl_Hire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_f_name;
        private System.Windows.Forms.Label f_name;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.TextBox textBox_l_name;
        private System.Windows.Forms.Label egn;
        private System.Windows.Forms.TextBox textBox_egn;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.ComboBox comboBox_position;
        private System.Windows.Forms.TextBox textBox_position_name;
        private GroceryShop.CustomBtn.RoundButton hire_button;
        private GroceryShop.CustomBtn.RoundButton add_position_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Label position_name;
        private System.Windows.Forms.Label position_lable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label employee_lable;
        private System.Windows.Forms.Label employee_exist;
        private System.Windows.Forms.Timer timer_exist_lable;
        private System.Windows.Forms.Label position_exist;
    }
}
