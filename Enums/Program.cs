﻿using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
          var mouse = new Product(1, "Mouse gamer", 299.90, EProductType.Product);


          mouse.Id = 55;

          Console.WriteLine(mouse.Id);
          Console.WriteLine(mouse.Name);
          Console.WriteLine(mouse.Price);
          Console.WriteLine(mouse.Type);
        }
    }
    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }

}