using System;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Tratamento de erros/excessões
            var array = new int[3];

            try 
            {
                for (var indice = 0; indice < 10; indice++)
            {
                Console.WriteLine(array[indice]);
            }

            } catch (Exception ex) {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
            finally
            {
                Console.WriteLine("Chegou ao fim");
            }
            
            /*var meuArray = new int[5] {1, 2, 3, 4, 5}; //sempre colocar o new para criar o array
            var meuArray2 = meuArray; // dessa forma não cria novo array, apenas indica que o array2 é o mesmo do 1

            /*for(var indice = 0; indice < meuArray.Length; indice++) {
                Console.WriteLine(meuArray[indice]);
            }

            foreach (var indice in meuArray)
            {
                Console.WriteLine(indice);
            }*/
        }
    }
}
