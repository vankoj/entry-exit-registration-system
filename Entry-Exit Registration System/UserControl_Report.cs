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
    public partial class UserControl_Report : UserControl
    {
        private static UserControl_Report _instance;

        public static UserControl_Report Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl_Report();
                }
                return _instance;
            }
        }

        public UserControl_Report()
        {
            InitializeComponent();
        }

        private void UserControl_Report_Load(object sender, EventArgs e)
        {
            personName.Text = "Име на служител";

            dataGridView1.Rows.Add("ime", "familiq", "egn", "poziciq", "chasive");
            dataGridView1.Rows.Add("ime", "familiq", "egn", "poziciq", "chasive");
            dataGridView1.Rows.Add("ime", "familiq", "egn", "poziciq", "chasive");
            dataGridView1.Rows.Add("ime", "familiq", "egn", "poziciq", "chasive");
            dataGridView1.Rows.Add("ime", "familiq", "egn", "poziciq", "chasive");
            dataGridView1.Rows.Add("ime", "familiq", "egn", "poziciq", "chasive");
            dataGridView1.Rows.Add("ime", "familiq", "egn", "poziciq", "chasive");
            dataGridView1.Rows.Add("ime", "familiq", "egn", "poziciq", "chasive");
            dataGridView1.Rows.Add("ime", "familiq", "egn", "poziciq", "chasive");
            dataGridView1.Rows.Add("ime", "familiq", "egn", "poziciq", "chasive");
        }
    }
}
