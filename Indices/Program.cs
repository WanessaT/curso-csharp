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

            // Converter para maiusculo e minusculo
            Console.WriteLine(texto.ToLower()); // Deixa tudo minusculo
            Console.WriteLine(texto.ToUpper()); //Deixa tudo maiusculo

            Console.WriteLine(texto.Insert(5, "AQUI ")); //Insere o que eu quiser, nesse caso está inserindo "AQUI" na posição 5
            Console.WriteLine(texto.Remove(5, 6)); // Remove informações, nesse caso, a partir da posição 5 ele está removendo os próximos 6 caracteres
            Console.WriteLine(texto.Length); // Conta quando caracteres possui a variavel



        }
    }
}
