using System;
using System.Collections.Generic;

namespace ASIMS.Models.Tables
{
    public partial class Market
    {
        public int Mno { get; set; }
        public int? Vno { get; set; }
        public int? Number { get; set; }
        public string Sphone { get; set; }
        public string Uphone { get; set; }
        public DateTime? RecordDate { get; set; }
        public int? Pflag { get; set; }

        public virtual Staff SphoneNavigation { get; set; }
        public virtual User UphoneNavigation { get; set; }
        public virtual Vehicle VnoNavigation { get; set; }
    }
}
