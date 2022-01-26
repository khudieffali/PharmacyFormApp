using System;
using System.Collections.Generic;

#nullable disable

namespace PharmacyFormApp.Models
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
