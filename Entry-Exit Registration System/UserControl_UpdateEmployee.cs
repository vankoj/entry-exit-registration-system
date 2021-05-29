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
    public partial class UserControl_UpdateEmployee : UserControl
    {
        private static UserControl_UpdateEmployee _instance;
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

        public static UserControl_UpdateEmployee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl_UpdateEmployee();
                }
                return _instance;
            }
        }

        public UserControl_UpdateEmployee()
        {
            InitializeComponent();
        }

        private void UserControl_UpdateEmployee_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

            database = DatabaseManager.Instance;

            label_f_name.Text = "Име";
            label_l_name.Text = "Фамилия";
            label_egn.Text = "ЕГН";
            label_position.Text = "Позиция";
            update_button.Text = "Обнови";

            textBox_egn.Enabled = false;

            textBox_f_name.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_f_name.Width, textBox_f_name.Height, 30, 30));
            textBox_l_name.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_l_name.Width, textBox_l_name.Height, 30, 30));
            textBox_egn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_egn.Width, textBox_egn.Height, 30, 30));
            comboBox_position.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBox_position.Width, comboBox_position.Height, 30, 30));

            dataGridViewRefresh();
        }

        public void dataGridViewRefresh()
        {
            dataGridView_employees.Rows.Clear();

            List<CheckInEvent> employees = database.GetEmployees();
            if (employees != null && employees.Count > 0)
            {
                foreach (CheckInEvent employee in employees)
                {
                    dataGridView_employees.Rows.Add(employee.F_Name, employee.L_Name, employee.EGN, employee.Position_Name);
                }
                dataGridView_employees.Rows[0].Selected = false;
            }

            comboBox_position.Items.Clear();

            List<String> positions = database.GetPositionNames();
            foreach (String position in positions)
            {
                comboBox_position.Items.Add(position);
            }

            comboBox_position.DropDownStyle = ComboBoxStyle.DropDownList;

            textBox_f_name.Text = "";
            textBox_l_name.Text = "";
            textBox_egn.Text = "";
            comboBox_position.Text = "";
        }

        private void dataGridView_employees_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_employees.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_employees.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_employees.Rows[selectedrowindex];
                textBox_f_name.Text = Convert.ToString(selectedRow.Cells["f_name"].Value);
                textBox_l_name.Text = Convert.ToString(selectedRow.Cells["l_name"].Value);
                textBox_egn.Text = Convert.ToString(selectedRow.Cells["id"].Value);
                comboBox_position.SelectedIndex = comboBox_position.Items.IndexOf(Convert.ToString(selectedRow.Cells["position"].Value));
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox_f_name.Text) && !String.IsNullOrEmpty(textBox_l_name.Text) &&
                !String.IsNullOrEmpty(textBox_egn.Text) && !String.IsNullOrEmpty(comboBox_position.Text) &&
                textBox_egn.TextLength == 10)
            {
                bool successful = true;

                successful = database.UpdateEmployee(textBox_egn.Text, textBox_f_name.Text, textBox_l_name.Text, comboBox_position.SelectedItem.ToString());

                if (!successful)
                {
                    MessageBox.Show("Обновяването бе неуспешно!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    textBox_f_name.Clear();
                    textBox_l_name.Clear();
                    textBox_egn.Clear();
                    comboBox_position.SelectedItem = null;
                    dataGridViewRefresh();
                }
            }
            else
            {
                MessageBox.Show("Моля попълнете всички полета!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridViewRefresh();
            }
        }
    }
}
