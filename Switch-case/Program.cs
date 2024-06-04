using System;

namespace Switch
{
    class Program
    {
        static void Main (string[] args)
        {
            string valor = "Andre";
            switch(valor)
            {
                case "Joao": Console.WriteLine("Não é o cara!");
                break;
                    
                case "Marcelo": Console.WriteLine("Não é o cara!");
                break;
                
                case "Andre": Console.WriteLine("É o cara!");
                break;

                default: Console.WriteLine("Não encontrei!");
                break;
            }

        }  
    }
}