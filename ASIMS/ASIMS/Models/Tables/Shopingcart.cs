using System;
using System.Collections.Generic;

namespace ASIMS.Models.Tables
{
    public partial class Shopingcart
    {
        public int Cno { get; set; }
        public string Uphone { get; set; }
        public int? Vno { get; set; }

        public virtual User UphoneNavigation { get; set; }
        public virtual Vehicle VnoNavigation { get; set; }
    }
}
