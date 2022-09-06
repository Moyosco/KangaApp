using System;
using System.Collections.Generic;

namespace KangaApp.Models
{
    public partial class Vendor
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; } = null!;
        public string VendorEmail { get; set; } = null!;
        public string VendorAddress { get; set; } = null!;
        public int ProductNumber { get; set; }
        public string PhoneNumber { get; set; } = null!;
    }
}
