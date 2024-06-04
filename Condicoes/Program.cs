using System;

namespace Condicoes
{
    class Program
    {
        static void Main (string[] args)
        {
            int idade = 18;
            int maioridade = 21;

            if(idade >= maioridade)
            {
                Console.WriteLine("Já é maior de idade.");
            } 
            else
            {
                Console.WriteLine("Ainda é menor de idade.");
            }
                

                Console.WriteLine("Finalizou o programa.");
        }
    }
}