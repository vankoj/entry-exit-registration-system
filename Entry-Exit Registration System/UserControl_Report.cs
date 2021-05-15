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
                    dateTimePicker1.Location = new Point(dateTimePicker1.Location.X, 15);
                    textBox_egn.Enabled = true;
                    break;
                case 3:
                    dateTimePicker1.Format = DateTimePickerFormat.Long;
                    dateTimePicker2.Format = DateTimePickerFormat.Long;
                    dateTimePicker2.Visible = true;
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
            DateTime today = DateTime.Now;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (textBox_egn.Text.Length == 10)
                    {
                        List<CheckInEvent> day = database.GetEmployeeCheckInsForDate(textBox_egn.Text, dateTimePicker1.Value);
                        if (day.Count <= 0)
                        {
                            MessageBox.Show("Не съществуват такива записи", "Грешка", MessageBoxButtons.OK);
                            textBox_egn.Focus();
                        }
                        else
                        {
                            foreach (CheckInEvent item in day)
                            {
                                if (item.Is_Entry)
                                {
                                    dataGridView1.Rows.Add(item.F_Name, item.L_Name, item.EGN, item.EGN, "На работа");
                                }
                                else
                                {
                                    TimeSpan duration = today.Subtract(item.Date_Time);
                                    dataGridView1.Rows.Add(item.F_Name, item.L_Name, item.EGN, item.EGN, duration.ToString(@"h\:m\:s"));
                                }
                            }
                        }
                        day.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Моля въведете валидно ЕГН", "Грешка", MessageBoxButtons.OK);
                        textBox_egn.Focus();
                    }
                    break;
                case 1:
                    if (textBox_egn.Text.Length == 10)
                    {
                        List<CheckInEvent> month = database.GetEmployeeCheckInsForMonth(textBox_egn.Text, dateTimePicker1.Value);
                        if (month.Count <= 0)
                        {
                            MessageBox.Show("Не съществуват такива записи", "Грешка", MessageBoxButtons.OK);
                            textBox_egn.Focus();
                        }
                        else
                        {
                            foreach (CheckInEvent item in month)
                            {
                                if (item.Is_Entry)
                                {
                                    dataGridView1.Rows.Add(item.F_Name, item.L_Name, item.EGN, item.EGN, "На работа");
                                }
                                else
                                {
                                    TimeSpan duration = today.Subtract(item.Date_Time);
                                    dataGridView1.Rows.Add(item.F_Name, item.L_Name, item.EGN, item.EGN, duration.ToString(@"h\:m\:s"));
                                }
                            }
                        }
                        month.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Моля въведете валидно ЕГН", "Грешка", MessageBoxButtons.OK);
                        textBox_egn.Focus();
                    }
                    break;
                case 2:
                    if (textBox_egn.Text.Length == 10)
                    {
                        List<CheckInEvent> period = database.GetEmployeeCheckInsForPeriod(textBox_egn.Text, dateTimePicker1.Value, dateTimePicker2.Value);
                        if (period.Count <= 0)
                        {
                            MessageBox.Show("Не съществуват такива записи", "Грешка", MessageBoxButtons.OK);
                            textBox_egn.Focus();
                        }
                        else
                        {
                            foreach (CheckInEvent item in period)
                            {
                                if (item.Is_Entry)
                                {
                                    dataGridView1.Rows.Add(item.F_Name, item.L_Name, item.EGN, item.EGN, "На работа");
                                }
                                else
                                {
                                    TimeSpan duration = today.Subtract(item.Date_Time);
                                    dataGridView1.Rows.Add(item.F_Name, item.L_Name, item.EGN, item.EGN, duration.ToString(@"h\:m\:s"));
                                }
                            }
                        }
                        period.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Моля въведете валидно ЕГН", "Грешка", MessageBoxButtons.OK);
                        textBox_egn.Focus();
                    }
                    break;
                case 3:
                    List<CheckInEvent> periodAll = database.GetEmployeesForPeriod(dateTimePicker1.Value, dateTimePicker2.Value);
                    if (periodAll.Count <= 0)
                    {
                        MessageBox.Show("Не съществуват такива записи", "Грешка", MessageBoxButtons.OK);
                        textBox_egn.Focus();
                    }
                    else
                    {
                        foreach (CheckInEvent item in periodAll)
                        {
                            if (item.Is_Entry)
                            {
                                dataGridView1.Rows.Add(item.F_Name, item.L_Name, item.EGN, item.EGN, "На работа");
                            }
                            else
                            {
                                TimeSpan duration = today.Subtract(item.Date_Time);
                                dataGridView1.Rows.Add(item.F_Name, item.L_Name, item.EGN, item.EGN, duration.ToString(@"h\:m\:s"));
                            }
                        }
                    }
                    periodAll.Clear();
                    break;
                default:
                    break;
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
