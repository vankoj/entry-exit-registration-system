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
    public partial class Report : UserControl
    {
        private static Report _instance;

        public static Report Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Report();
                }
                return _instance;
            }
        }

        public Report()
        {
            InitializeComponent();
        }
    }
}
