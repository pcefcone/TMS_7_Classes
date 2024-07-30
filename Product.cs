using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_7_Classes
{
    internal abstract class Product
    {
        Random rnd = new Random();
        private double _price;
        private int _id;
        private int _amount;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public int Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
        public Product()
        {
            Price = Convert.ToDouble(rnd.Next(1, 100));
            Id = rnd.Next(1, 1000);
            Amount = rnd.Next(1, 10);
        }
        public Product(double price)
        {
            Price = price;
            Id = rnd.Next(1, 1000);
            Amount = rnd.Next(1, 10);
        }
        public Product(int amount)
        {
            Price = Convert.ToDouble(rnd.Next(1, 100));
            Id = rnd.Next(1, 1000);
            Amount = amount;
        }
        public Product(double price, int amount)
        {
            Price = price;
            Id = rnd.Next(1, 1000);
            Amount = amount;
        }
    }
    internal class Electronic : Product
    {
        public Electronic() : base()
        {

        }
        public Electronic(double price) : base(price)
        {

        }
        public Electronic(int amount) : base(amount)
        {

        }
        public Electronic(double price, int amount) : base(price, amount)
        {

        }
    }

    internal class Basic : Product
    {
        public Basic() : base()
        {

        }
        public Basic(double price) : base(price)
        {

        }
        public Basic(int amount) : base(amount)
        {

        }
        public Basic(double price, int amount) : base(price, amount)
        {

        }
    }

    internal class Furniture : Product
    {
        public Furniture() : base()
        {

        }
        public Furniture(double price) : base(price)
        {

        }
        public Furniture(int amount) : base(amount)
        {

        }
        public Furniture(double price, int amount) : base(price, amount)
        {

        }
    }

    internal class Equipment : Product
    {
        double pricesSummary = 0.0;
        double cartTotal = 0.0;
        int amountSummary = 0;
        int ids = 0;

        List<Product> _products;
        public List<Product> Products
        {
            get
            {
                return _products;
            }
            set
            {
                _products = value;
            }
        }
        public Equipment(List<Product> products)
        {
            Products = products;
        }
        public double GetCartTotalPrice()
        {
            foreach (Product product in Products)
            {
                cartTotal += product.Price * product.Amount;
            }
            return cartTotal;

        }
        public double GetProductPrices()
        {
            int count = 0;
            foreach (Product product in Products)
            {
                count++;
                pricesSummary += product.Price;
                Console.Write($"Product{count} price = {Math.Round(product.Price, 2)} EUR, ");
            }
            Console.WriteLine();
            return pricesSummary;
        }
        public double GetProductAmount()
        {
            foreach (Product product in Products)
            {
                int count = 0;
                count++;
                amountSummary += product.Amount;
                Console.Write($"Product{count} amount = {product.Amount}, ");
            }
            Console.WriteLine();
            return amountSummary;
        }
        public int GetProductIds()
        {
            int count = 0;
            foreach (Product product in Products)
            {
                count++;
                ids = product.Id;
                Console.Write($"Product{count} id = {product.Id}, ");
            }
            Console.WriteLine();
            return ids;
        }

    }
}
