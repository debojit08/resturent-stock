using System;
using System.Collections.Generic;

#nullable disable

namespace Resturent.Models
{
    public partial class Supplier
    {
        public long SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public long? MobileNo { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EDate { get; set; }
        public DateTime? MDate { get; set; }
    }
}
