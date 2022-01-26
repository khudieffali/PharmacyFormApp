using System;
using System.Collections.Generic;

#nullable disable

namespace PharmacyFormApp.Models
{
    public partial class Tag
    {
        public Tag()
        {
            TagToMedicines = new HashSet<TagToMedicine>();
        }

        public int TagId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TagToMedicine> TagToMedicines { get; set; }
    }
}
