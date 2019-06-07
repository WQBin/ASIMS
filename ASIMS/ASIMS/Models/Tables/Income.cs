using System;
using System.Collections.Generic;

namespace ASIMS.Models.Tables
{
    public partial class Income
    {
        public int Vno { get; set; }
        public int? Vnumber { get; set; }
        public float? Vincome { get; set; }

        public virtual Vehicle VnoNavigation { get; set; }
    }
}
