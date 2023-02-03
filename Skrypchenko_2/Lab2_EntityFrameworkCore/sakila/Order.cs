using System;
using System.Collections.Generic;

#nullable disable

namespace Lab2_EntityFrameworkCore.sakila
{
    public partial class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int Count { get; set; }
        public int? IdCompany { get; set; }
        public int? IdProduct { get; set; }
    }
}
