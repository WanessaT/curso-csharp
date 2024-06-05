using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            MeuMetodo();

            string nome = RetornaNome("Wanessa" , "Loureiro");
            Console.WriteLine(nome);
        }

        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal!");
        }

        static string RetornaNome(string nome, string sobrenome) //pode ter parâmetros adicionais desde que já tenha atribuição e esteja situado no final. Ex: int idade = 27
        {
            return nome + " " + sobrenome;
        }
    }
}