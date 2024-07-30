using System.Diagnostics;
using System.Security.Cryptography;
using TMS_7_Classes;

namespace Products
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Electronic(price: 77.20, amount: 9));
            products.Add(new Basic(amount: 14));
            products.Add(new Furniture(price: 99.99));
            Equipment equipment = new Equipment(products);
            equipment.GetProductIds();
            equipment.GetProductPrices();
            equipment.GetProductAmount();
            double result = Math.Round(equipment.GetCartTotalPrice(), 2);
            Console.WriteLine($"Cost of all products in your cart {result} EUR");
        }
    }
}


