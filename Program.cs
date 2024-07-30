using System.Diagnostics;
using System.Security.Cryptography;

namespace Products
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
        List<Equipment> _equipment;
        public List<Equipment> Equipments
        {
            get
            {
                return _equipment;
            }
            set
            {
                _equipment = value;
            }
        }
        public 
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            long accountNumber = Convert.ToInt64(Console.ReadLine());
            double accountAmount = Convert.ToDouble(Console.ReadLine());
            CreditCard.AddAmount();
        }

        public class CreditCard()
        {
            public static void AddAmount()
            {

            }
            public static void AddAmount(double acccountAmount)
            {
                long accountNumber = 1234563453210204;
                Console.WriteLine(acccountAmount);
                Console.WriteLine(accountNumber);
            }

            public static void AddAmount(long accountNumber)
            {
                double accountAmount = 15003.20;
                Console.WriteLine(accountNumber);
                Console.WriteLine(accountAmount);
            }
        }


    }
}


