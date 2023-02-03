using System;
using System.Collections.Generic;

#nullable disable

namespace Lab2_EntityFrameworkCore.sakila
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public string Unit { get; set; }
    }

}
