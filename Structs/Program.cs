using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
          var mouse = new Product(1, "Mouse gamer", 299.90);

          mouse.Id = 55;

          Console.WriteLine(mouse.Id);
          Console.WriteLine(mouse.Name);
          Console.WriteLine(mouse.Price);
        }
    }
    
    struct Product
    {
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public int Id;
        public string Name;
        public double Price;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }
}