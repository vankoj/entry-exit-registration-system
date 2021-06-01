
namespace Entry_Exit_Registration_System
{
    partial class UserControl_Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_egn = new System.Windows.Forms.TextBox();
            this.personEGN = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.period = new System.Windows.Forms.Label();
            this.check_button = new GroceryShop.CustomBtn.RoundButton();
            this.f_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.f_name,
            this.l_name,
            this.id,
            this.position,
            this.work_hours,
            this.entry});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
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
            this.dataGridView1.Size = new System.Drawing.Size(900, 300);
            this.dataGridView1.TabIndex = 5;
            // 
            // textBox_egn
            // 
            this.textBox_egn.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox_egn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_egn.Location = new System.Drawing.Point(17, 45);
            this.textBox_egn.Name = "textBox_egn";
            this.textBox_egn.Size = new System.Drawing.Size(220, 30);
            this.textBox_egn.TabIndex = 0;
            this.textBox_egn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_egn_KeyPress);
            // 
            // personEGN
            // 
            this.personEGN.AutoSize = true;
            this.personEGN.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.personEGN.Location = new System.Drawing.Point(12, 15);
            this.personEGN.Name = "personEGN";
            this.personEGN.Size = new System.Drawing.Size(110, 26);
            this.personEGN.TabIndex = 2;
            this.personEGN.Text = "personEGN";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(481, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2021, 4, 27, 18, 25, 10, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(481, 53);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ден",
            "Месец",
            "Период",
            "Всички служители"});
            this.comboBox1.Location = new System.Drawing.Point(253, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 30);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // period
            // 
            this.period.AutoSize = true;
            this.period.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.period.Location = new System.Drawing.Point(248, 15);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(67, 26);
            this.period.TabIndex = 7;
            this.period.Text = "period";
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
            this.check_button.Location = new System.Drawing.Point(746, 45);
            this.check_button.Name = "check_button";
            this.check_button.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.check_button.OnHoverButtonColor = System.Drawing.Color.SeaGreen;
            this.check_button.OnHoverTextColor = System.Drawing.Color.Black;
            this.check_button.Size = new System.Drawing.Size(124, 30);
            this.check_button.TabIndex = 4;
            this.check_button.Text = "check_button";
            this.check_button.TextColor = System.Drawing.Color.Black;
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // f_name
            // 
            this.f_name.Frozen = true;
            this.f_name.HeaderText = "Име";
            this.f_name.MinimumWidth = 125;
            this.f_name.Name = "f_name";
            this.f_name.ReadOnly = true;
            this.f_name.Width = 125;
            // 
            // l_name
            // 
            this.l_name.Frozen = true;
            this.l_name.HeaderText = "Фамилия";
            this.l_name.MinimumWidth = 125;
            this.l_name.Name = "l_name";
            this.l_name.ReadOnly = true;
            this.l_name.Width = 125;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ЕГН";
            this.id.MinimumWidth = 80;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 80;
            // 
            // position
            // 
            this.position.Frozen = true;
            this.position.HeaderText = "Позиция";
            this.position.MinimumWidth = 100;
            this.position.Name = "position";
            this.position.ReadOnly = true;
            // 
            // work_hours
            // 
            this.work_hours.Frozen = true;
            this.work_hours.HeaderText = "Изработени часове";
            this.work_hours.MinimumWidth = 130;
            this.work_hours.Name = "work_hours";
            this.work_hours.ReadOnly = true;
            this.work_hours.Width = 130;
            // 
            // entry
            // 
            this.entry.HeaderText = "Влиза/Излиза";
            this.entry.MinimumWidth = 80;
            this.entry.Name = "entry";
            this.entry.ReadOnly = true;
            this.entry.Width = 80;
            // 
            // UserControl_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.period);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.personEGN);
            this.Controls.Add(this.textBox_egn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl_Report";
            this.Size = new System.Drawing.Size(900, 400);
            this.Load += new System.EventHandler(this.UserControl_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_egn;
        private System.Windows.Forms.Label personEGN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label period;
        private GroceryShop.CustomBtn.RoundButton check_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry;
    }
}
