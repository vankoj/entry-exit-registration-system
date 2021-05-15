using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Entry_Exit_Registration_System
{
    public partial class Form_EasterEgg : Form
    {
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_EasterEgg()
        {
            InitializeComponent();
            this.Text = "Чекиране на служители - Изработили";
            this.MaximizeBox = false;
        }

        int counter = 0;
        int len1 = 0, len2 = 0, len3 = 0, len4 = 0, len5 = 0, len6 = 0;
        string author1name, author2name, author3name;
        string author1fn, author2fn, author3fn;

        private void Form_EasterEgg_Load(object sender, EventArgs e)
        {
            closeButton.Cursor = Cursors.Hand;
            windowName.Text = "Чекиране на служители - Изработили";

            name1.Text = "";
            name2.Text = "";
            name3.Text = "";
            fn1.Text = "";
            fn2.Text = "";
            fn3.Text = "";

            author1name = "Денислав Иванов";
            author2name = "Димитър Йорданов";
            author3name = "Иван Йорданов";
            author1fn = "18621731";
            author2fn = "18621734";
            author3fn = "18621719";

            len1 = author1name.Length;
            len2 = author2name.Length;
            len3 = author3name.Length;
            len4 = author1fn.Length;
            len5 = author2fn.Length;
            len6 = author3fn.Length;

            timer1.Start();

        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            name1.Text = author1name.Substring(0, counter);

            ++counter;

            if (counter > len1)
            {
                timer1.Stop();

                timer2.Start();

                counter = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            name2.Text = author2name.Substring(0, counter);

            ++counter;

            if (counter > len2)
            {
                timer2.Stop();

                timer3.Start();

                counter = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            name3.Text = author3name.Substring(0, counter);

            ++counter;

            if (counter > len3)
            {
                timer3.Stop();

                timer4.Start();

                counter = 0;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            fn1.Text = author1fn.Substring(0, counter);

            ++counter;

            if (counter > len4)
            {
                timer4.Stop();

                timer5.Start();

                counter = 0;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            fn2.Text = author2fn.Substring(0, counter);

            ++counter;

            if (counter > len5)
            {
                timer5.Stop();

                timer6.Start();

                counter = 0;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            fn3.Text = author3fn.Substring(0, counter);

            ++counter;

            if (counter > len6)
            {
                timer6.Stop();

                counter = 0;
            }
        }
    }
}
