using System;
using System.Collections.Generic;

namespace KangaApp.Models
{
    public partial class Client
    {
        public string ClientName { get; set; } = null!;
        public string ClientAddress { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public int ProductNumber { get; set; }
    }
}
