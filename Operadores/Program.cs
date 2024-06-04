using System;

namespace Operadores
{
    class Program{
        static void Main(string[] args)
        {
            //Operador aritmético
            int x = 2;
            x = (2 + 2) * 5;

            //Operador de atribuição
            x += 9;

            //Operador de incremento
            x++;

            Console.WriteLine(x == 30); // == Operador de comparação
        }
    }
}