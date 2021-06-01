using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entry_Exit_Registration_System
{
    public partial class UserControl_Report : UserControl
    {
        private static UserControl_Report _instance;
        private DatabaseManager database;

        // Round Controls
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );

        public static UserControl_Report Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl_Report();
                }
                return _instance;
            }
        }

        public UserControl_Report()
        {
            InitializeComponent();
        }

        private void UserControl_Report_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

            database = DatabaseManager.Instance;

            this.ActiveControl = textBox_egn;

            personEGN.Text = "ЕГН на служител";
            period.Text = "Период";
            check_button.Text = "Проверка";

            textBox_egn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_egn.Width, textBox_egn.Height, 30, 30));
            comboBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBox1.Width, comboBox1.Height, 30, 30));
            dateTimePicker1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dateTimePicker1.Width, dateTimePicker1.Height, 30, 30));
            dateTimePicker2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dateTimePicker2.Width, dateTimePicker2.Height, 30, 30));
            dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Now;

            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            dateTimePicker2.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dateTimePicker1.Format = DateTimePickerFormat.Long;
                    dateTimePicker2.Visible = false;
                    dateTimePicker1.Location = new Point(dateTimePicker1.Location.X, 40);
                    textBox_egn.Enabled = true;
                    break;
                case 1:
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "MMMM, yyyy";
                    dateTimePicker2.Visible = false;
                    dateTimePicker1.Location = new Point(dateTimePicker1.Location.X, 40);
                    textBox_egn.Enabled = true;
                    break;
                case 2:
                    dateTimePicker1.Format = DateTimePickerFormat.Long;
                    dateTimePicker2.Format = DateTimePickerFormat.Long;
                    dateTimePicker2.Visible = true;
                    dateTimePicker2.Value = DateTime.Now.AddDays(1);
                    dateTimePicker1.Location = new Point(dateTimePicker1.Location.X, 15);
                    textBox_egn.Enabled = true;
                    break;
                case 3:
                    dateTimePicker1.Format = DateTimePickerFormat.Long;
                    dateTimePicker2.Format = DateTimePickerFormat.Long;
                    dateTimePicker2.Visible = true;
                    dateTimePicker2.Value = DateTime.Now.AddDays(1);
                    dateTimePicker1.Location = new Point(dateTimePicker1.Location.X, 15);
                    textBox_egn.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<CheckInEvent> items = new List<CheckInEvent>();

            if (textBox_egn.Text.Length == 10 || comboBox1.SelectedIndex == 3)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        items = database.GetEmployeeCheckInsForDate(textBox_egn.Text, dateTimePicker1.Value);
                        break;
                    case 1:
                        items = database.GetEmployeeCheckInsForMonth(textBox_egn.Text, dateTimePicker1.Value);
                        break;
                    case 2:
                        items = database.GetEmployeeCheckInsForPeriod(textBox_egn.Text, dateTimePicker1.Value, dateTimePicker2.Value);
                        break;
                    case 3:
                        items = database.GetEmployeesForPeriod(dateTimePicker1.Value, dateTimePicker2.Value);
                        break;
                }

                if (items.Count <= 0)
                {
                    MessageBox.Show("Не съществуват такива записи", "Грешка", MessageBoxButtons.OK);
                    textBox_egn.Focus();
                }
                else
                {
                    foreach (CheckInEvent item in items)
                    {
                        dataGridView1.Rows.Add(item.F_Name, item.L_Name, item.EGN, item.Position_Name, item.Date_Time, item.Is_Entry ? "Влиза" : "Излиза");
                    }
                }
                items.Clear();
            }
            else
            {
                MessageBox.Show("Моля въведете валидно ЕГН", "Грешка", MessageBoxButtons.OK);
                textBox_egn.Focus();
            }
        }

        private void textBox_egn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || textBox_egn.Text.Length >= 10)
            {
                e.Handled = true;
                textBox_egn.Focus();
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                textBox_egn.Focus();
            }
            if (e.KeyChar == (char)Keys.Return) check_button_Click(sender, e);
        }
    }
}
