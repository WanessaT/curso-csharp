using System;

namespace Indice
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.IndexOf("é")); //Acha a posição que o caractere está
            Console.WriteLine(texto.LastIndexOf("s")); //Acha o indice da ultima vez que a letra ou palavra se repete
        }
    }
}
