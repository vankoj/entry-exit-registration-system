
namespace Entry_Exit_Registration_System
{
    partial class UserControl_ReleaseEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer_removed_lable = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.position_removed = new System.Windows.Forms.Label();
            this.position_lable = new System.Windows.Forms.Label();
            this.remove_position_button = new GroceryShop.CustomBtn.RoundButton();
            this.dataGridView_positions = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_removed = new System.Windows.Forms.Label();
            this.employee_lable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_employees = new System.Windows.Forms.DataGridView();
            this.f_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.release_employrr_button = new GroceryShop.CustomBtn.RoundButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_positions)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_removed_lable
            // 
            this.timer_removed_lable.Tick += new System.EventHandler(this.timer_removed_lable_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.position_removed);
            this.panel2.Controls.Add(this.position_lable);
            this.panel2.Controls.Add(this.remove_position_button);
            this.panel2.Controls.Add(this.dataGridView_positions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(532, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 400);
            this.panel2.TabIndex = 3;
            // 
            // position_removed
            // 
            this.position_removed.AutoSize = true;
            this.position_removed.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.position_removed.ForeColor = System.Drawing.Color.DarkRed;
            this.position_removed.Location = new System.Drawing.Point(10, 290);
            this.position_removed.Name = "position_removed";
            this.position_removed.Size = new System.Drawing.Size(210, 30);
            this.position_removed.TabIndex = 16;
            this.position_removed.Text = "position_removed";
            // 
            // position_lable
            // 
            this.position_lable.AutoSize = true;
            this.position_lable.Font = new System.Drawing.Font("Sylfaen", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.position_lable.Location = new System.Drawing.Point(40, 46);
            this.position_lable.Name = "position_lable";
            this.position_lable.Size = new System.Drawing.Size(179, 36);
            this.position_lable.TabIndex = 13;
            this.position_lable.Text = "position_lable";
            // 
            // remove_position_button
            // 
            this.remove_position_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remove_position_button.BorderColor = System.Drawing.Color.Silver;
            this.remove_position_button.ButtonColor = System.Drawing.Color.Cornsilk;
            this.remove_position_button.FlatAppearance.BorderSize = 0;
            this.remove_position_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.remove_position_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.remove_position_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_position_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remove_position_button.Location = new System.Drawing.Point(122, 350);
            this.remove_position_button.Name = "remove_position_button";
            this.remove_position_button.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.remove_position_button.OnHoverButtonColor = System.Drawing.Color.SeaGreen;
            this.remove_position_button.OnHoverTextColor = System.Drawing.Color.Black;
            this.remove_position_button.Size = new System.Drawing.Size(200, 30);
            this.remove_position_button.TabIndex = 3;
            this.remove_position_button.Text = "remove_position_button";
            this.remove_position_button.TextColor = System.Drawing.Color.Black;
            this.remove_position_button.UseVisualStyleBackColor = true;
            this.remove_position_button.Click += new System.EventHandler(this.remove_position_button_Click);
            // 
            // dataGridView_positions
            // 
            this.dataGridView_positions.AllowUserToAddRows = false;
            this.dataGridView_positions.AllowUserToDeleteRows = false;
            this.dataGridView_positions.AllowUserToResizeColumns = false;
            this.dataGridView_positions.AllowUserToResizeRows = false;
            this.dataGridView_positions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_positions.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView_positions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_positions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_positions.ColumnHeadersHeight = 30;
            this.dataGridView_positions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_positions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_positions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_positions.EnableHeadersVisualStyles = false;
            this.dataGridView_positions.GridColor = System.Drawing.Color.White;
            this.dataGridView_positions.Location = new System.Drawing.Point(25, 125);
            this.dataGridView_positions.Name = "dataGridView_positions";
            this.dataGridView_positions.ReadOnly = true;
            this.dataGridView_positions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_positions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_positions.RowHeadersWidth = 30;
            this.dataGridView_positions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_positions.RowTemplate.Height = 24;
            this.dataGridView_positions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_positions.Size = new System.Drawing.Size(317, 150);
            this.dataGridView_positions.TabIndex = 2;
            // 
            // number
            // 
            this.number.HeaderText = "№";
            this.number.MinimumWidth = 40;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 40;
            // 
            // name
            // 
            this.name.HeaderText = "Име";
            this.name.MinimumWidth = 165;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 165;
            // 
            // employee_removed
            // 
            this.employee_removed.AutoSize = true;
            this.employee_removed.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employee_removed.ForeColor = System.Drawing.Color.DarkRed;
            this.employee_removed.Location = new System.Drawing.Point(20, 290);
            this.employee_removed.Name = "employee_removed";
            this.employee_removed.Size = new System.Drawing.Size(229, 30);
            this.employee_removed.TabIndex = 15;
            this.employee_removed.Text = "employee_removed";
            // 
            // employee_lable
            // 
            this.employee_lable.AutoSize = true;
            this.employee_lable.Font = new System.Drawing.Font("Sylfaen", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employee_lable.Location = new System.Drawing.Point(40, 46);
            this.employee_lable.Name = "employee_lable";
            this.employee_lable.Size = new System.Drawing.Size(199, 36);
            this.employee_lable.TabIndex = 14;
            this.employee_lable.Text = "employee_lable";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.dataGridView_employees);
            this.panel1.Controls.Add(this.employee_removed);
            this.panel1.Controls.Add(this.employee_lable);
            this.panel1.Controls.Add(this.release_employrr_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 400);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView_employees
            // 
            this.dataGridView_employees.AllowUserToAddRows = false;
            this.dataGridView_employees.AllowUserToDeleteRows = false;
            this.dataGridView_employees.AllowUserToResizeColumns = false;
            this.dataGridView_employees.AllowUserToResizeRows = false;
            this.dataGridView_employees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView_employees.EnableHeadersVisualStyles = false;
            this.dataGridView_employees.GridColor = System.Drawing.Color.White;
            this.dataGridView_employees.Location = new System.Drawing.Point(25, 125);
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
            this.dataGridView_employees.Size = new System.Drawing.Size(487, 150);
            this.dataGridView_employees.TabIndex = 0;
            // 
            // f_name
            // 
            this.f_name.HeaderText = "Име";
            this.f_name.MinimumWidth = 125;
            this.f_name.Name = "f_name";
            this.f_name.ReadOnly = true;
            this.f_name.Width = 125;
            // 
            // l_name
            // 
            this.l_name.HeaderText = "Фамилия";
            this.l_name.MinimumWidth = 125;
            this.l_name.Name = "l_name";
            this.l_name.ReadOnly = true;
            this.l_name.Width = 125;
            // 
            // id
            // 
            this.id.HeaderText = "ЕГН";
            this.id.MinimumWidth = 100;
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
            // release_employrr_button
            // 
            this.release_employrr_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.release_employrr_button.BorderColor = System.Drawing.Color.Silver;
            this.release_employrr_button.ButtonColor = System.Drawing.Color.Cornsilk;
            this.release_employrr_button.FlatAppearance.BorderSize = 0;
            this.release_employrr_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.release_employrr_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.release_employrr_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.release_employrr_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.release_employrr_button.Location = new System.Drawing.Point(282, 350);
            this.release_employrr_button.Name = "release_employrr_button";
            this.release_employrr_button.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.release_employrr_button.OnHoverButtonColor = System.Drawing.Color.SeaGreen;
            this.release_employrr_button.OnHoverTextColor = System.Drawing.Color.Black;
            this.release_employrr_button.Size = new System.Drawing.Size(200, 30);
            this.release_employrr_button.TabIndex = 1;
            this.release_employrr_button.Text = "release_employrr_button";
            this.release_employrr_button.TextColor = System.Drawing.Color.Black;
            this.release_employrr_button.UseVisualStyleBackColor = true;
            this.release_employrr_button.Click += new System.EventHandler(this.release_employrr_button_Click);
            // 
            // UserControl_ReleaseEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_ReleaseEmployee";
            this.Size = new System.Drawing.Size(900, 400);
            this.Load += new System.EventHandler(this.UserControl_ReleaseEmployee_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_positions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_removed_lable;
        private System.Windows.Forms.Panel panel2;
        private GroceryShop.CustomBtn.RoundButton remove_position_button;
        private System.Windows.Forms.Label employee_removed;
        private System.Windows.Forms.Label employee_lable;
        private GroceryShop.CustomBtn.RoundButton release_employrr_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label position_lable;
        private System.Windows.Forms.DataGridView dataGridView_positions;
        private System.Windows.Forms.Label position_removed;
        private System.Windows.Forms.DataGridView dataGridView_employees;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}
