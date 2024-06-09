using System;
using System.Runtime.InteropServices;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Tela();
            Opcoes();

            var opcao = short.Parse(Console.ReadLine());
            OpcaoMenu(opcao);
        }

        public static void Tela()
        {
            Console.Write("+");
            for (int coluna = 0; coluna <= 30; coluna++)
                Console.Write("-");
            
            Console.Write("+");
            Console.Write("\n");

            for (int linha = 0; linha <= 10; linha++)
            {
                Console.Write("|");
                for (int coluna = 0; coluna <= 30; coluna++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int coluna = 0; coluna <= 30; coluna++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void Opcoes()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("---------------------");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");

        }

        public static void OpcaoMenu(short opcao)
        {
            switch(opcao)
            {
                case 1: Console.WriteLine("Editor"); break;
                case 2: Console.WriteLine("Visualizar"); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
}