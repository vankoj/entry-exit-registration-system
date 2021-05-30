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
    public partial class Form_Cheking : Form
    {
        private DatabaseManager databaseManager;

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

        // On Mouse Down on panel1 move window
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_Cheking()
        {
            InitializeComponent();
            this.Text = "Чекиране на служители";
            this.MaximizeBox = false;

            databaseManager = DatabaseManager.Instance;
        }

        private void Form_Cheking_Load(object sender, EventArgs e)
        {
            minimizeButton.Cursor = Cursors.Hand;
            closeButton.Cursor = Cursors.Hand;
            windowName.Text = "Чекиране на служители";
            check_button.Cursor = Cursors.Hand;
            textBox_checking.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_checking.Width, textBox_checking.Height, 30, 30));

            top_lable.Text = "Чекиране на служители";
            input_label.Text = "Потребителски номер";
            check_button.Text = "Чекиране";
            this.ActiveControl = textBox_checking;
        }

        private void Form_Cheking_FormClosing(object sender, FormClosingEventArgs e)
        {
            databaseManager.Dispose();
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            if (databaseManager.CheckIfAdminExists(textBox_checking.Text))
            {
                this.Hide();

                Form_AdminLogin form = new Form_AdminLogin();
                form.ShowDialog();

                this.Show();

                textBox_checking.Text = "";
                this.ActiveControl = textBox_checking;
            }
            else if (string.IsNullOrEmpty(textBox_checking.Text))
            {
                MessageBox.Show("Моля въведете потребителски номер", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActiveControl = textBox_checking;
            }
            else
            {
                // TODO - да се чекира служителя и да се смени MessageBox-а
                // TODO - проверка дали такъв служител съществува (и MessageBox, ако няма такъв)
                MessageBox.Show(textBox_checking.Text, "Чекиране", MessageBoxButtons.OK, MessageBoxIcon.Question);

                textBox_checking.Text = "";
                this.ActiveControl = textBox_checking;
            }
        }

        private void textBox_checking_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) check_button_Click(sender, e);
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back || textBox_checking.Text.Length >= 10)
            {
                e.Handled = true;
                textBox_checking.Focus();
            }
        }

        private void top_lable_Click(object sender, EventArgs e)
        {
            Form_EasterEgg form = new Form_EasterEgg();
            form.ShowDialog();
            this.ActiveControl = textBox_checking;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
