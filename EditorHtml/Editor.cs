using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR - Para salvar pressione ENTER e em seguida ESC");
            Console.WriteLine("-------------");
            Start();
        }

        public static void Start()
        {
            var arquivo = new StringBuilder();

            do {
                arquivo.Append(Console.ReadLine());
                arquivo.AppendLine(Environment.NewLine);

            }while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("---------------");
            Console.WriteLine("DDeseja salvar o arquivo?");
        }
    }
}