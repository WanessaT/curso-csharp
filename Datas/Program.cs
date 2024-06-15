using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //var data = new DateTime(); - Inicializa com a data e hora padrão 01/01, porém pode especificar a data colocando entre os ()
            var data = DateTime.Now; //mostra a atual
            Console.WriteLine(data);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine(data.DayOfYear);
        }
    }
}
