using System;
using System.Collections.Generic;

#nullable disable

namespace PharmacyFormApp.Models
{
    public partial class Medicine
    {
        public Medicine()
        {
            Orders = new HashSet<Order>();
            TagToMedicines = new HashSet<TagToMedicine>();
        }

        public int MedicineId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool IsReceipt { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int? FirmId { get; set; }

        public virtual Firm Firm { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<TagToMedicine> TagToMedicines { get; set; }
    }
}
