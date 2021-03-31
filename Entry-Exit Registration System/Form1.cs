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
    public partial class Form1 : Form
    {
        private DatabaseManager databaseManager;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Чекиране на служители";

            databaseManager = new DatabaseManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            top_lable.Text = "Чекиране на служители";
            top_lable.Font = new Font("Mistral", 30, FontStyle.Regular);
            input_label.Text = "Потребителски номер";
            input_label.Font = new Font("Sylfaen", 12, FontStyle.Regular);
            check_button.Text = "Чекиране";
            this.ActiveControl = textBox_checking; // Не работи
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            databaseManager.Dispose();
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            if (textBox_checking.Text == "666")
            {
                // Временно зареждане на Администраторската форма
                this.Hide();

                Form2 form2 = new Form2();
                form2.ShowDialog();

                this.Show();

                textBox_checking.Text = "";
                this.ActiveControl = textBox_checking; // Не работи
            }
            else if (!string.IsNullOrEmpty(textBox_checking.Text))
            {
                MessageBox.Show(textBox_checking.Text, "Чекиране", MessageBoxButtons.OK, MessageBoxIcon.Question);

                textBox_checking.Text = "";
                this.ActiveControl = textBox_checking; // Не работи
            }
            else
            {
                MessageBox.Show("Моля въведете потребителски номер", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActiveControl = textBox_checking; // Не работи
            }
        }

        private void textBox_checking_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back || textBox_checking.Text.Length >= 10)
            {
                e.Handled = true;
                textBox_checking.Focus(); // Не работи
            }
            else if (e.KeyChar == (char)Keys.Return) check_button_Click(sender, e);
        }
    }
}
