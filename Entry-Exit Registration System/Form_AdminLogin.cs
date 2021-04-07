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
    public partial class Form_AdminLogin : Form
    {
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

        // On Mouse Down on panel1 move window
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_AdminLogin()
        {
            InitializeComponent();
            this.Text = "Вход на администратор";
            this.MaximizeBox = false;
        }

        private void Form_AdminLogin_Load(object sender, EventArgs e)
        {
            minimizeButton.Cursor = Cursors.Hand;
            closeButton.Cursor = Cursors.Hand;
            windowName.Text = "Вход на администратор";
            login_button.Cursor = Cursors.Hand;
            textBox_username.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_username.Width, textBox_username.Height, 30, 30));
            textBox_password.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_password.Width, textBox_password.Height, 30, 30));

            username_lable.Text = "Потребителско име:";
            passowrd_label.Text = "Парола:";
            login_button.Text = "Вход";
            this.ActiveControl = textBox_username;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form_AdminPanel form = new Form_AdminPanel();
            form.ShowDialog();

            this.Close();
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
