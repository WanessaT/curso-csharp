using System;
using Microsoft.VisualBasic.FileIO;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comparação de strings
            var texto = "Esse texto é um teste.";
            Console.WriteLine(texto.CompareTo("teste")); //Compara se é totalmente igual e retorna um inteiro
            Console.WriteLine(texto.Contains("Teste")); //Confere se contém e retorna um boleano
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); //Ignora o case sensitive

            //Starts e End With (Começa e termina com) retorna um boleano, é case sensitive
            Console.WriteLine(texto.StartsWith("Esse"));
            Console.WriteLine(texto.StartsWith("este"));

            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste"));
            




        }
    }
}