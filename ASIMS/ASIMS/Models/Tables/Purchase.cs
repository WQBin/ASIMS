using System;
using System.Collections.Generic;

namespace ASIMS.Models.Tables
{
    public partial class Purchase
    {
        public int Pno { get; set; }
        public int? Vno { get; set; }
        public int? Sno { get; set; }
        public float? PcostPrice { get; set; }
        public int? Pnumber { get; set; }
        public DateTime? PrecordDate { get; set; }

        public virtual Suppler SnoNavigation { get; set; }
        public virtual Vehicle VnoNavigation { get; set; }
    }
}
