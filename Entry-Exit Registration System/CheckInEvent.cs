using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry_Exit_Registration_System
{
    class CheckInEvent
    {
        public string EGN { get; set; }
        public string F_Name { get; set; }
        public string L_Name { get; set; }
        public string Position_Name { get; set; }
        public DateTime Date_Time { get; set; }
        public Boolean Is_Entry { get; set; }

        public CheckInEvent(string EGN, string F_Name, string L_Name, string Position_Name, DateTime Date_Time, Boolean Is_Entry)
        {
            this.EGN = EGN;
            this.F_Name = F_Name;
            this.L_Name = L_Name;
            this.Position_Name = Position_Name;
            this.Date_Time = Date_Time;
            this.Is_Entry = Is_Entry;
        }
    }
}
