using System;
using System.Collections.Generic;

namespace KangaApp.Models
{
    public partial class Product
    {
        public int ProductNumber { get; set; }
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
        public int Quantity { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
