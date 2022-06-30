using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine(" Modo Viewer");
            Console.WriteLine("===================");
            Replace(text);
            Console.WriteLine("\n===================");
            Console.Write("Deseja salvar s/n: ");

            string option = Console.ReadLine().ToLower();
            if (option == "s")
            {
                Save.Show(text);
                Console.ReadLine();
            }
            else if (option == "n")
            {
                Console.WriteLine("<<<<<<<<<<>>>>>>>>>");
                Console.WriteLine("1 - Novo arquivo");
                Console.WriteLine("2 - Menu ");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("<<<<<<<<<<>>>>>>>>>");
                Console.Write("Opcao: ");

                var optioN = short.Parse(Console.ReadLine());

                switch (optioN)
                {
                    case 1: Editor.Show(); break;
                    case 2: Menu.Show(); break;
                    default:
                        {
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            else
            {
                Console.Write("Deseja salvar s/n: ");
                Console.ReadLine();
            }
            Console.ReadKey();
            Menu.Show();


        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            // Console.Write(strong);

            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (words[i].LastIndexOf('<') - 1) -
                                words[i].IndexOf('>')
                            )
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }

        }
    }

}

