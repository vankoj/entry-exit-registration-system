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
        private DatabaseManager database = DatabaseManager.Instance;

        // Roud Controls
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
            personName.Text = "Име на служител";
            period.Text = "Период";
            check_button.Text = "Проверка";

            textBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 30, 30));
            comboBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBox1.Width, comboBox1.Height, 30, 30));
            dateTimePicker1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dateTimePicker1.Width, dateTimePicker1.Height, 30, 30));
            dateTimePicker2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dateTimePicker2.Width, dateTimePicker2.Height, 30, 30));

            comboBox1.Items.Insert(0, "Ден");
            comboBox1.Items.Insert(1, "Месец");
            comboBox1.Items.Insert(2, "Период");
            comboBox1.Items.Insert(3, "Всички служители");
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            dateTimePicker2.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    dateTimePicker1.Format = DateTimePickerFormat.Long;
                    dateTimePicker2.Visible = false;
                    dateTimePicker1.Location = new Point(dateTimePicker1.Location.X, 40);
                    textBox1.Enabled = true;
                    break;
                case 1:
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "MMMM, yyyy";
                    dateTimePicker2.Visible = false;
                    dateTimePicker1.Location = new Point(dateTimePicker1.Location.X, 40);
                    textBox1.Enabled = true;
                    break;
                case 2:
                    dateTimePicker1.Format = DateTimePickerFormat.Long;
                    dateTimePicker2.Format = DateTimePickerFormat.Long;
                    dateTimePicker2.Visible = true;
                    dateTimePicker1.Location = new Point(dateTimePicker1.Location.X, 15);
                    textBox1.Enabled = true;
                    break;
                case 3:
                    dateTimePicker1.Format = DateTimePickerFormat.Long;
                    dateTimePicker2.Format = DateTimePickerFormat.Long;
                    dateTimePicker2.Visible = true;
                    dateTimePicker1.Location = new Point(dateTimePicker1.Location.X, 15);
                    textBox1.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                // TODO: Да се направи записването на резултатът и извеждането
                case 0:
                    database.GetEmployeeCheckInsForDate(textBox1.Text, dateTimePicker1.Value);
                    break;
                case 1:
                    database.GetEmployeeCheckInsForMonth(textBox1.Text, dateTimePicker1.Value);
                    break;
                case 2:
                    database.GetEmployeeCheckInsForPeriod(textBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value);
                    break;
                case 3:
                    database.GetEmployeesForPeriod(dateTimePicker1.Value, dateTimePicker2.Value);
                    break;
                default:
                    break;
            }
        }
    }
}
