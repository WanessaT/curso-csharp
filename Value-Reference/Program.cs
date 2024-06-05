﻿using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo Value Types
            int x = 25;
            int y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            x = 32;
            Console.WriteLine(x);
            Console.WriteLine(y);
            
            // Exemplo Reference Types
            var arr = new string[2];
            arr[0] = "Item 1";

            var arr2 = arr;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "Item 2";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

        }
    }
}