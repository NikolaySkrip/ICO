using Lab2_EntityFrameworkCore.sakila;
using System;
using System.Linq;

namespace Lab2_EntityFrameworkCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Lab1Context db = new Lab1Context())
            {
                // получаем объекты из бд и выводим на консоль

                var companies = db.Companies.ToList();
                Console.WriteLine("Products:");
                foreach (Company c in companies)
                {
                    Console.WriteLine($"{c.Id} {c.Name} {c.Ceo} {c.Phone} {c.Address}");
                }


                Console.WriteLine();

                var products = db.Products.ToList();
                Console.WriteLine("Products:");
                foreach (Product p in products)
                {
                    Console.WriteLine($"{p.Id} {p.Name} {p.Description} {p.Price} {p.Discount} {p.Unit}");
                }

                Console.WriteLine();

                var orders = db.Orders.ToList();
                Console.WriteLine("Orders:");
                foreach (Order o in orders)
                {
                    Company c = db.Companies.First(x=>x.Id == o.IdCompany);
                    Product p = db.Products.First(x => x.Id == o.IdProduct);
                    Console.WriteLine($"{o.Id} {c.Name} {p.Name} {o.OrderDate} {o.Count} {o.Count * p.Price}");
                }

            }
        }
    }
}
