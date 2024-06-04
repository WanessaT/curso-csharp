using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 100;
            float real = 25.8f;

            //real = inteiro; (conversão implícita)
            //inteiro = (int)real; (conversão explícita)
            //inteiro = int.Parse(real.ToString()); (conversão com parse, porém ele só recebe se for string)
            inteiro = Convert.ToInt32(real); // (conversão usando o Convert)

            Console.WriteLine(inteiro);

        }
    }
}

