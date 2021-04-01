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
    public partial class UpdateEmployee : UserControl
    {
        private static UpdateEmployee _instance;

        public static UpdateEmployee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UpdateEmployee();
                }
                return _instance;
            }
        }

        public UpdateEmployee()
        {
            InitializeComponent();
        }
    }
}
