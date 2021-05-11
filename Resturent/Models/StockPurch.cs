using System;
using System.Collections.Generic;

#nullable disable

namespace Resturent.Models
{
    public partial class StockPurch
    {
        public long PurchesItemId { get; set; }
        public long? SupplierId { get; set; }
        public string ItemName { get; set; }
        public long? Qty { get; set; }
        public string Unit { get; set; }
        public string PricePerUnit { get; set; }
        public long? Amount { get; set; }
        public long? Cgst { get; set; }
        public long? Sgst { get; set; }
        public long? TotalAmount { get; set; }
        public bool? PaymentType { get; set; }
        public DateTime? EDate { get; set; }
        public DateTime? MDate { get; set; }
    }
}
