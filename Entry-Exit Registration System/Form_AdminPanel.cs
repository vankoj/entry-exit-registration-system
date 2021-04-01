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
            release_employee_button.Text = "Премахни служител";
        }

        private void report_button_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(Report.Instance))
            {
                panel.Controls.Add(Report.Instance);
                Report.Instance.Dock = DockStyle.Fill;
                Report.Instance.BringToFront();
            }
            else Report.Instance.BringToFront();
        }

        private void hire_button_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(Hire.Instance))
            {
                panel.Controls.Add(Hire.Instance);
                Hire.Instance.Dock = DockStyle.Fill;
                Hire.Instance.BringToFront();
            }
            else Hire.Instance.BringToFront();
        }

        private void update_employee_button_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(UpdateEmployee.Instance))
            {
                panel.Controls.Add(UpdateEmployee.Instance);
                UpdateEmployee.Instance.Dock = DockStyle.Fill;
                UpdateEmployee.Instance.BringToFront();
            }
            else UpdateEmployee.Instance.BringToFront();
        }

        private void release_employee_button_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ReleaseEmployee.Instance))
            {
                panel.Controls.Add(ReleaseEmployee.Instance);
                ReleaseEmployee.Instance.Dock = DockStyle.Fill;
                ReleaseEmployee.Instance.BringToFront();
            }
            else ReleaseEmployee.Instance.BringToFront();
        }
    }
}
