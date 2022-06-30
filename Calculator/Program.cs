using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("----------------Menu-----------------");
            Console.WriteLine("Escolha a qual deseja usar:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Multiplicao");
            Console.WriteLine("4 - Divisao");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-------------------------------------");
            Console.Write($"Digite o numero: ");

            short respMenu = short.Parse(Console.ReadLine());

            switch (respMenu)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("-------------SOMA-------------");
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo a valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"A soma dos numeros: {resultado}");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("1 - Fazer nova conta");
            Console.WriteLine("2 - Menu");
            Console.WriteLine("3 - Ate mais ;)");

            short subMenu = short.Parse(Console.ReadLine());

            switch (subMenu)
            {
                case 1: Soma(); break;
                case 2: Menu(); break;
                default: System.Environment.Exit(0); break;
            }

            Console.ReadKey();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("-------------SUBTRACAO-------------");
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"A Subtracao dos numeros: {resultado}");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("1 - Fazer nova conta");
            Console.WriteLine("2 - Menu");
            Console.WriteLine("3 - Ate mais ;)");

            short subMenu = short.Parse(Console.ReadLine());

            switch (subMenu)
            {
                case 1: Subtracao(); break;
                case 2: Menu(); break;
                default: System.Environment.Exit(0); break;
            }

            Console.ReadKey();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("-------------MULTIPLICAO-------------");
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"A Multiplicacao dos numeros: {resultado}");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("1 - Fazer nova conta");
            Console.WriteLine("2 - Menu");
            Console.WriteLine("3 - Ate mais ;)");

            short subMenu = short.Parse(Console.ReadLine());

            switch (subMenu)
            {
                case 1: Multiplicacao(); break;
                case 2: Menu(); break;
                default: System.Environment.Exit(0); break;
            }

            Console.ReadKey();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("-------------DIVISAO-------------");
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"A Divisao dos numeros: {resultado}");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("1 - Fazer nova conta");
            Console.WriteLine("2 - Menu");
            Console.WriteLine("3 - Ate mais ;)");

            short subMenu = short.Parse(Console.ReadLine());

            switch (subMenu)
            {
                case 1: Divisao(); break;
                case 2: Menu(); break;
                default: System.Environment.Exit(0); break;
            }

            Console.ReadKey();
        }
    }
}
