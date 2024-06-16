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
            //Console.WriteLine(data);
            //Console.WriteLine(data.DayOfWeek); // mostra o dia da semana
            //Console.WriteLine(data.DayOfYear); // mostra o dia do ano

            var formatada = String.Format("{0:dd/MM/yyyy}", data);
            Console.WriteLine(formatada);

        }
    }
}
