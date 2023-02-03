using System;
using System.Collections.Generic;

#nullable disable

namespace Lab2_EntityFrameworkCore.sakila
{
    public partial class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ceo { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
