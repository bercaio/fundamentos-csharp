using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Gray;

            DrawScreen();
            WriteOption();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);

        }

        public static void DrawScreen()
        {
            Column(40);
            Line(10);
        }

        public static void Column(short column)
        {
            Console.Write("+");
            for (int i = 0; i <= column; i++)
                Console.Write("-");

            Console.WriteLine("+");
        }

        public static void Line(short lines)
        {
            for (int i = 0; i <= lines; i++)
            {
                Console.Write("|");
                for (int line = 0; line <= 40; line++)
                    Console.Write(" ");

                Console.WriteLine("|");

            }
            Column(40);
        }

        public static void WriteOption()
        {
            Console.SetCursorPosition(15, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(10, 3);
            Console.WriteLine("+++++++++++++++++++++");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Selecione uma opcao abaixo:");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(2, 10);
            Console.Write("Opcao: ");

        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}