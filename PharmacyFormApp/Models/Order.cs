using System;
using System.Collections.Generic;

#nullable disable

namespace PharmacyFormApp.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? MedicineId { get; set; }
        public int? WorkerId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }

        public virtual Medicine Medicine { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
