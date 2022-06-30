using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(String[] args)
        {
            Menu();
        }

        static void Menu()
        {

            Console.Clear();
            Console.WriteLine("O que voce deseja fazer:");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Creat(); break;
                default: Menu(); break;
            }
        }

        static void Open()
        {
            Console.Clear();
            Console.WriteLine($"Qual o nome do arquivo que deseja abrir? ");
            string namePath = Console.ReadLine();
            var path = @"C:\Cursos\dotnet\Arquivos" + namePath;

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);

            }

            Console.WriteLine("");
            Console.Read();
            Menu();

        }

        static void Creat()

        {
            Console.Clear();
            Console.WriteLine("Pronto para criar seu texto! (ESC - para sair)");
            Console.WriteLine("______________________________________________");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write(text);

            Console.WriteLine("______________________________________________");
            Console.Write("Deseja salvar? s/n: ");
            string option = Console.ReadLine().ToLower();


            if (option == "s")
                Save(text);
            else if (option == "n")
                System.Environment.Exit(0);
            else
                Console.ReadLine();
            Menu();

        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o nome do arquivo? ");
            string namePath = Console.ReadLine();
            var path = @"C:\Cursos\dotnet\Arquivos\" + namePath + ".txt";
            Console.WriteLine($"Caminho do arquivo: {path}");
            Console.WriteLine("-----------------------------");


            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo salvo com sucesso!!!");
            Console.ReadLine();

            Menu();





        }
    }
}