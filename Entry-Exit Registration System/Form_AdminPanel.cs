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
    public partial class Form_AdminPanel : Form
    {
        public Form_AdminPanel()
        {
            InitializeComponent();
            this.Text = "Администраторско работно поле";
        }

        private void Form_AdminWorkSpace_Load(object sender, EventArgs e)
        {
            report_button.Text = "Справка";
            hire_button.Text = "Добави служител";
            update_employee_button.Text = "Актуализация на служител";
            release_button.Text = "Премахни служител";
        }
    }
}
