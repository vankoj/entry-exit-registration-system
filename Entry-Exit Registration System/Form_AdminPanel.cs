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
    public partial class Form_AdminPanel : Form
    {
        private static String title = "Чекиране на служители";

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

        public Form_AdminPanel()
        {
            InitializeComponent();
            this.Text = "Администраторско работно поле";
            this.MaximizeBox = false;
        }

        private void Form_AdminWorkSpace_Load(object sender, EventArgs e)
        {
            minimizeButton.Cursor = Cursors.Hand;
            closeButton.Cursor = Cursors.Hand;
            windowName.Text = title;
            report_button.Cursor = Cursors.Hand;
            hire_button.Cursor = Cursors.Hand;
            update_employee_button.Cursor = Cursors.Hand;
            release_employee_button.Cursor = Cursors.Hand;

            report_button.Text = "Справка";
            hire_button.Text = "Добави служител / позиция";
            release_employee_button.Text = "Премахни служител / позиция";
            update_employee_button.Text = "Служители";

            this.ActiveControl = report_button;

            loadUserControls();
        }

        private void loadUserControls()
        {
            Panel clearPanel = new Panel();
            clearPanel.Size = new Size(900, 395);
            clearPanel.BackColor = Color.SeaGreen;

            if (!panel.Controls.Contains(clearPanel))
            {
                panel.Controls.Add(clearPanel);
            }

            if (!panel.Controls.Contains(null))
            {
                panel.Controls.Add(null);
            }
            
            if (!panel.Controls.Contains(UserControl_Report.Instance))
            {
                panel.Controls.Add(UserControl_Report.Instance);
                UserControl_Report.Instance.Dock = DockStyle.Fill;
            }

            if (!panel.Controls.Contains(UserControl_Hire.Instance))
            {
                panel.Controls.Add(UserControl_Hire.Instance);
                UserControl_Hire.Instance.Dock = DockStyle.Fill;
            }

            if (!panel.Controls.Contains(UserControl_ReleaseEmployee.Instance))
            {
                panel.Controls.Add(UserControl_ReleaseEmployee.Instance);
                UserControl_ReleaseEmployee.Instance.Dock = DockStyle.Fill;
            }

            if (!panel.Controls.Contains(UserControl_UpdateEmployee.Instance))
            {
                panel.Controls.Add(UserControl_UpdateEmployee.Instance);
                UserControl_UpdateEmployee.Instance.Dock = DockStyle.Fill;
            }

            // Задава чист панел за начален фон
            clearPanel.BringToFront();
        }

        private void report_button_Click(object sender, EventArgs e)
        {
            windowName.Text = title + " - Справка";
            UserControl_Report.Instance.BringToFront();
            UserControl_Report.Instance.Focus();
        }

        private void hire_button_Click(object sender, EventArgs e)
        {
            windowName.Text = title + " - Добави служител / позиция";
            UserControl_Hire.Instance.BringToFront();
            UserControl_Hire.Instance.Focus();
        }

        private void release_employee_button_Click(object sender, EventArgs e)
        {
            windowName.Text = title + " - Премахни служител / позиция";
            UserControl_ReleaseEmployee.Instance.BringToFront();
            UserControl_ReleaseEmployee.Instance.Focus();
        }

        private void update_employee_button_Click(object sender, EventArgs e)
        {
            windowName.Text = title + " - Служители";
            UserControl_UpdateEmployee.Instance.BringToFront();
            UserControl_UpdateEmployee.Instance.Focus();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
