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

            textBox_f_name.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_f_name.Width, textBox_f_name.Height, 30, 30));
            textBox_l_name.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_l_name.Width, textBox_l_name.Height, 30, 30));
            textBox_egn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_egn.Width, textBox_egn.Height, 30, 30));
            comboBox_position.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBox_position.Width, comboBox_position.Height, 30, 30));
        }
    }
}
