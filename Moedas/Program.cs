using System;
using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 200.35m; 

            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(Math.Round(valor)); //Arredonda o valor 
            Console.WriteLine(Math.Ceiling(valor)); //Arredonda para cima
            Console.WriteLine(Math.Floor(valor)); //Arredonda para baixo
        }
    }
}