using System;
using System.Collections.Generic;

#nullable disable

namespace PharmacyFormApp.Models
{
    public partial class TagToMedicine
    {
        public int TagMedicineId { get; set; }
        public int? TagId { get; set; }
        public int? MedicineId { get; set; }

        public virtual Medicine Medicine { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
