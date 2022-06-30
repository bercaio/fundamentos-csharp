using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Modo Editor");
            Console.WriteLine("===================");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();
            file.ToString();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine(" ====================");
            Console.Write("Deseja salvar s/n: ");
            Viewer.Show(file.ToString());

            // if (option == "s")
            // {
            //     Save.Show(file.ToString());
            //     Console.ReadLine();
            // }
            // else if (option == "n")
            // {
            //     Console.WriteLine("<<<<<<<<<<>>>>>>>>>");
            //     Console.WriteLine("1 - Novo arquivo");
            //     Console.WriteLine("2 - Menu ");
            //     Console.WriteLine("0 - Sair");
            //     Console.WriteLine("<<<<<<<<<<>>>>>>>>>");
            //     Console.Write("Opcao: ");

            //     var optioN = short.Parse(Console.ReadLine());

            //     switch (optioN)
            //     {
            //         case 1: Show(); break;
            //         case 2: Menu.Show(); break;
            //         default:
            //             {
            //                 Console.Clear();
            //                 Environment.Exit(0);
            //                 break;
            //             }
            //     }
            // }
            // else
            // {
            //     Console.Write("Deseja salvar s/n: ");
            //     Console.ReadLine();
            // }

        }


    }
}