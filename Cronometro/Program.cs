using System;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            //Start(6);
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Quanto tempo deseja contar?");
            Console.WriteLine("S = Segundo -> ex: 10s = 10 segundos");
            Console.WriteLine("M = Minuto -> ex: 1m = 1 minuto");
            Console.WriteLine("0s = Sair");

            string dados = Console.ReadLine().ToLower();
            char type = char.Parse(dados.Substring(dados.Length - 1, 1)); //Substring pega uma quantidade de dados expecíficos
            int time = int.Parse(dados.Substring(0, dados.Length - 1));
            int multiplica = 1;

            if(type == 'm')
                multiplica = 60;
            
            if(time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplica);

        }

        static void PreStart(int tempo)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Vamos!");
            Thread.Sleep(2000);

            Start(tempo);

        }

        static void Start(int tempo)
        {
            int tempoAtual = 0;

            while(tempoAtual != tempo)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronometro finalizado!");
            Thread.Sleep(2000);
            Menu();
        }
    }
}