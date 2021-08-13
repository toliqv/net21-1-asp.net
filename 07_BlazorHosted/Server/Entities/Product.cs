using System;
using System.Collections.Generic;

#nullable disable

namespace _07_BlazorHosted.Server.Entities
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public string Vendor { get; set; }
    }
}
