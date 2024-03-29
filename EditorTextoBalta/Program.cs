﻿using System;
using System.IO;

namespace EditorTextoBalta
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
            Console.WriteLine("O que voce deseja fazer? ");
            Console.WriteLine("1 - Abir Aquivo");
            Console.WriteLine("2 - Creiar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }

        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o nome do arquivo?");
            string path = @"C:\Cursos\dotnet\Arquivos\" + Console.ReadLine() + ".txt";

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();

        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine(" Digite seu texto abaixo (ESC - Para sair)");
            Console.WriteLine("----------------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("----------------");
            Console.WriteLine(text);

            Console.ReadLine();
            Salvar(text);

        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual nome do arquivo?");
            string nomeArquivo = Console.ReadLine();
            var path = @"C:\Cursos\dotnet\Arquivos\" + nomeArquivo + ".txt";

            using (var file = new StreamWriter(path))
            {
                file.Write(text);

            }

            Console.WriteLine($"Arquivo {nomeArquivo} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }

    }
}
