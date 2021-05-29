
namespace Entry_Exit_Registration_System
{
    partial class UserControl_UpdateEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_employees = new System.Windows.Forms.DataGridView();
            this.f_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_f_name = new System.Windows.Forms.TextBox();
            this.textBox_l_name = new System.Windows.Forms.TextBox();
            this.textBox_egn = new System.Windows.Forms.TextBox();
            this.comboBox_position = new System.Windows.Forms.ComboBox();
            this.label_f_name = new System.Windows.Forms.Label();
            this.label_l_name = new System.Windows.Forms.Label();
            this.label_egn = new System.Windows.Forms.Label();
            this.label_position = new System.Windows.Forms.Label();
            this.update_button = new GroceryShop.CustomBtn.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_employees
            // 
            this.dataGridView_employees.AllowUserToAddRows = false;
            this.dataGridView_employees.AllowUserToDeleteRows = false;
            this.dataGridView_employees.AllowUserToResizeColumns = false;
            this.dataGridView_employees.AllowUserToResizeRows = false;
            this.dataGridView_employees.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView_employees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_employees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_employees.ColumnHeadersHeight = 30;
            this.dataGridView_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.f_name,
            this.l_name,
            this.id,
            this.position});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_employees.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_employees.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_employees.EnableHeadersVisualStyles = false;
            this.dataGridView_employees.GridColor = System.Drawing.Color.White;
            this.dataGridView_employees.Location = new System.Drawing.Point(0, 90);
            this.dataGridView_employees.MultiSelect = false;
            this.dataGridView_employees.Name = "dataGridView_employees";
            this.dataGridView_employees.ReadOnly = true;
            this.dataGridView_employees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_employees.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_employees.RowHeadersWidth = 30;
            this.dataGridView_employees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_employees.RowTemplate.Height = 24;
            this.dataGridView_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_employees.Size = new System.Drawing.Size(900, 300);
            this.dataGridView_employees.TabIndex = 1;
            this.dataGridView_employees.SelectionChanged += new System.EventHandler(this.dataGridView_employees_SelectionChanged);
            // 
            // f_name
            // 
            this.f_name.HeaderText = "Име";
            this.f_name.MinimumWidth = 150;
            this.f_name.Name = "f_name";
            this.f_name.ReadOnly = true;
            this.f_name.Width = 150;
            // 
            // l_name
            // 
            this.l_name.HeaderText = "Фамилия";
            this.l_name.MinimumWidth = 150;
            this.l_name.Name = "l_name";
            this.l_name.ReadOnly = true;
            this.l_name.Width = 150;
            // 
            // id
            // 
            this.id.HeaderText = "ЕГН";
            this.id.MinimumWidth = 125;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // position
            // 
            this.position.HeaderText = "Позиция";
            this.position.MinimumWidth = 120;
            this.position.Name = "position";
            this.position.ReadOnly = true;
            this.position.Width = 120;
            // 
            // textBox_f_name
            // 
            this.textBox_f_name.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox_f_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_f_name.Location = new System.Drawing.Point(20, 45);
            this.textBox_f_name.Name = "textBox_f_name";
            this.textBox_f_name.Size = new System.Drawing.Size(150, 30);
            this.textBox_f_name.TabIndex = 2;
            // 
            // textBox_l_name
            // 
            this.textBox_l_name.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox_l_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_l_name.Location = new System.Drawing.Point(210, 45);
            this.textBox_l_name.Name = "textBox_l_name";
            this.textBox_l_name.Size = new System.Drawing.Size(150, 30);
            this.textBox_l_name.TabIndex = 3;
            // 
            // textBox_egn
            // 
            this.textBox_egn.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox_egn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_egn.Location = new System.Drawing.Point(400, 45);
            this.textBox_egn.Name = "textBox_egn";
            this.textBox_egn.Size = new System.Drawing.Size(150, 30);
            this.textBox_egn.TabIndex = 4;
            // 
            // comboBox_position
            // 
            this.comboBox_position.BackColor = System.Drawing.Color.Cornsilk;
            this.comboBox_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.comboBox_position.FormattingEnabled = true;
            this.comboBox_position.Location = new System.Drawing.Point(590, 45);
            this.comboBox_position.Name = "comboBox_position";
            this.comboBox_position.Size = new System.Drawing.Size(150, 30);
            this.comboBox_position.TabIndex = 5;
            // 
            // label_f_name
            // 
            this.label_f_name.AutoSize = true;
            this.label_f_name.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.label_f_name.Location = new System.Drawing.Point(15, 16);
            this.label_f_name.Name = "label_f_name";
            this.label_f_name.Size = new System.Drawing.Size(129, 26);
            this.label_f_name.TabIndex = 7;
            this.label_f_name.Text = "label_f_name";
            // 
            // label_l_name
            // 
            this.label_l_name.AutoSize = true;
            this.label_l_name.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.label_l_name.Location = new System.Drawing.Point(205, 16);
            this.label_l_name.Name = "label_l_name";
            this.label_l_name.Size = new System.Drawing.Size(129, 26);
            this.label_l_name.TabIndex = 8;
            this.label_l_name.Text = "label_l_name";
            // 
            // label_egn
            // 
            this.label_egn.AutoSize = true;
            this.label_egn.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.label_egn.Location = new System.Drawing.Point(395, 16);
            this.label_egn.Name = "label_egn";
            this.label_egn.Size = new System.Drawing.Size(95, 26);
            this.label_egn.TabIndex = 9;
            this.label_egn.Text = "label_egn";
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.label_position.Location = new System.Drawing.Point(585, 16);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(133, 26);
            this.label_position.TabIndex = 10;
            this.label_position.Text = "label_position";
            // 
            // update_button
            // 
            this.update_button.BorderColor = System.Drawing.Color.Silver;
            this.update_button.ButtonColor = System.Drawing.Color.Cornsilk;
            this.update_button.FlatAppearance.BorderSize = 0;
            this.update_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.update_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_button.Location = new System.Drawing.Point(770, 45);
            this.update_button.Name = "update_button";
            this.update_button.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.update_button.OnHoverButtonColor = System.Drawing.Color.SeaGreen;
            this.update_button.OnHoverTextColor = System.Drawing.Color.Black;
            this.update_button.Size = new System.Drawing.Size(124, 30);
            this.update_button.TabIndex = 6;
            this.update_button.Text = "update_button";
            this.update_button.TextColor = System.Drawing.Color.Black;
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // UserControl_UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.Controls.Add(this.label_position);
            this.Controls.Add(this.label_egn);
            this.Controls.Add(this.label_l_name);
            this.Controls.Add(this.label_f_name);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.comboBox_position);
            this.Controls.Add(this.textBox_egn);
            this.Controls.Add(this.textBox_l_name);
            this.Controls.Add(this.textBox_f_name);
            this.Controls.Add(this.dataGridView_employees);
            this.Name = "UserControl_UpdateEmployee";
            this.Size = new System.Drawing.Size(900, 390);
            this.Load += new System.EventHandler(this.UserControl_UpdateEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_employees;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.TextBox textBox_f_name;
        private System.Windows.Forms.TextBox textBox_l_name;
        private System.Windows.Forms.TextBox textBox_egn;
        private System.Windows.Forms.ComboBox comboBox_position;
        private GroceryShop.CustomBtn.RoundButton update_button;
        private System.Windows.Forms.Label label_f_name;
        private System.Windows.Forms.Label label_l_name;
        private System.Windows.Forms.Label label_egn;
        private System.Windows.Forms.Label label_position;
    }
}
