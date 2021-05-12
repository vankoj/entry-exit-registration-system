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
    public partial class UserControl_Hire : UserControl
    {
        private static UserControl_Hire _instance;
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
        public static UserControl_Hire Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl_Hire();
                }
                return _instance;
            }
        }

        public UserControl_Hire()
        {
            InitializeComponent();
        }

        private void UserControl_Hire_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox_f_name;

            f_name.Text = "Име";
            l_name.Text = "Фамилия";
            egn.Text = "ЕГН";
            position.Text = "Позоция";
            hire_button.Text = "Въведи служител";

            position_lable.Text = "Въвеждане на позиция";
            position_name.Text = "Име на позиция";
            add_position_button.Text = "Въведи позиция";

            textBox_f_name.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_f_name.Width, textBox_f_name.Height, 30, 30));
            textBox_l_name.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_l_name.Width, textBox_l_name.Height, 30, 30));
            textBox_egn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_egn.Width, textBox_egn.Height, 30, 30));
            textBox_position_name.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_position_name.Width, textBox_position_name.Height, 30, 30));
            comboBox_position.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBox_position.Width, comboBox_position.Height, 30, 30));

            refreshPositions();
        }

        private void refreshPositions()
        {
            comboBox_position.Items.Clear();
            dataGridView1.Rows.Clear();
            int index = 1;

            List<String> positions = database.getPositionNames();
            foreach (string position in positions)
            {
                comboBox_position.Items.Add(position);
                dataGridView1.Rows.Add(index++, position);
            }

            comboBox_position.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void hire_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_f_name.Text) && !String.IsNullOrEmpty(textBox_l_name.Text) &&
                !String.IsNullOrEmpty(textBox_egn.Text) && !String.IsNullOrEmpty(comboBox_position.Text) &&
                textBox_egn.TextLength == 10)
            {
                database.InsertEmployee(textBox_egn.Text, textBox_f_name.Text, textBox_l_name.Text, comboBox_position.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Моля попълнете всички полета!", "Грешка");
            }
        }

        private void add_position_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_position_name.Text))
            {
                database.InsertPosition(textBox_position_name.Text);
                refreshPositions();
            }
            else
            {
                MessageBox.Show("Моля попълнете име на позицията!", "Грешка");
            }
        }

        private void textBox_f_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                textBox_f_name.Focus();
            }
            if (e.KeyChar == (char)Keys.Return) hire_button_Click(sender, e);
        }

        private void textBox_l_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                textBox_l_name.Focus();
            }
            if (e.KeyChar == (char)Keys.Return) hire_button_Click(sender, e);
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
            if (e.KeyChar == (char)Keys.Return) hire_button_Click(sender, e);
        }

        private void textBox_position_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                textBox_l_name.Focus();
            }
            if (e.KeyChar == (char)Keys.Return) add_position_button_Click(sender, e);
        }
    }
}
