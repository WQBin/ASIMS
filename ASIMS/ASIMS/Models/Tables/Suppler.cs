using System;
using System.Collections.Generic;

namespace ASIMS.Models.Tables
{
    public partial class Suppler
    {
        public Suppler()
        {
            Purchase = new HashSet<Purchase>();
        }

        public int Sno { get; set; }
        public string Sname { get; set; }
        public string SlinkMan { get; set; }
        public string Sphone { get; set; }
        public int? Saddress { get; set; }
        public string Sbank { get; set; }
        public string Sbankno { get; set; }
        public string Snote { get; set; }

        public virtual ICollection<Purchase> Purchase { get; set; }
    }
}
