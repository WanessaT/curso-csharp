using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fundamentos do Guid:

            var id = Guid.NewGuid();
            id.ToString();

            Console.WriteLine(id.ToString().Substring(0 ,8));
            */

            //Interpolação de String

            var price = 10.2;
            // var texto = "O preço do produto é " + price + "apenas na promoção."; (Modelo concatenado)
            // var texto = string.Format("O preço do produto é {0} apenas na promoção.", price); (Modelo Format)
            var texto = $"O preço do produto é {price} apenas na promoção"; // (Modelo interpolado)

            Console.WriteLine(texto);
        }
    }
}
