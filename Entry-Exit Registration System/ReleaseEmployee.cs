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
    public partial class ReleaseEmployee : UserControl
    {
        private static ReleaseEmployee _instance;

        public static ReleaseEmployee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ReleaseEmployee();
                }
                return _instance;
            }
        }

        public ReleaseEmployee()
        {
            InitializeComponent();
        }
    }
}
