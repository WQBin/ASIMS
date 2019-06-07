using System;
using System.Collections.Generic;

namespace ASIMS.Models.Tables
{
    public partial class User
    {
        public User()
        {
            Market = new HashSet<Market>();
            Shopingcart = new HashSet<Shopingcart>();
        }

        public string Uphone { get; set; }
        public string Upassword { get; set; }
        public string Uname { get; set; }
        public int? Uaddress { get; set; }

        public virtual ICollection<Market> Market { get; set; }
        public virtual ICollection<Shopingcart> Shopingcart { get; set; }
    }
}
