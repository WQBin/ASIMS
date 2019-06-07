using System;
using System.Collections.Generic;

namespace ASIMS.Models.Tables
{
    public partial class Staff
    {
        public Staff()
        {
            Market = new HashSet<Market>();
        }

        public string Sphone { get; set; }
        public string Spassword { get; set; }
        public string Stype { get; set; }
        public string Sname { get; set; }
        public string Ssex { get; set; }
        public int? Sage { get; set; }
        public int? Saddress { get; set; }
        public string Sacademic { get; set; }
        public float? Sperformance { get; set; }
        public int? CarNum { get; set; }

        public virtual ICollection<Market> Market { get; set; }
    }
}
