using System;
using System.Collections.Generic;

namespace ASIMS.Models.Tables
{
    public partial class Cashlist
    {
        public int Vno { get; set; }
        public int? Vnumber { get; set; }

        public virtual Vehicle VnoNavigation { get; set; }
    }
}
