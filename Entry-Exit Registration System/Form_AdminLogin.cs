using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entry_Exit_Registration_System
{
    public partial class Form_AdminLogin : Form
    {
        public Form_AdminLogin()
        {
            InitializeComponent();
            this.Text = "Вход на администратор";
            this.MaximizeBox = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            username_lable.Text = "Потребителско име:";
            username_lable.Font = new Font("Sylfaen", 12, FontStyle.Regular);
            passowrd_label.Text = "Парола:";
            passowrd_label.Font = new Font("Sylfaen", 12, FontStyle.Regular);
            login_button.Text = "Вход";
            this.ActiveControl = textBox_username;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form_AdminPanel form3 = new Form_AdminPanel();
            form3.ShowDialog();

            this.Show();
        }
    }
}
