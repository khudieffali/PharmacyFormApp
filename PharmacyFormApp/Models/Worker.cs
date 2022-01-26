using System;
using System.Collections.Generic;

#nullable disable

namespace PharmacyFormApp.Models
{
    public partial class Worker
    {
        public Worker()
        {
            Orders = new HashSet<Order>();
        }

        public int WorkerId { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
