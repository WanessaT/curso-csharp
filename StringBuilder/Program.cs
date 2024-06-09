using System;
using System.Text;

namespace StringB
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = new StringBuilder(); // método construtor
            texto.Append("Este texto é um teste."); // append anexa algo novo
            texto.Append(" Aqui testamos o append.");

            texto.ToString();
            Console.WriteLine(texto);
    
        }
    }
}
