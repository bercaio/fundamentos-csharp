using System;
using System.Threading;

namespace Stopwatch
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
            Console.WriteLine("S - Segundo => 10s = 10 segundos");
            Console.WriteLine("M - Minuto => 10m = 10 minutos");
            Console.WriteLine("00 - Sair");
            Console.Write("Quanto tempo deseja contar: ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static async void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparece vai comecar...");
            Thread.Sleep(2000);
            Console.WriteLine("Go...");
            Start(time);


        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.Write(currentTime);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Stopwatch finalizado!!!");
            Thread.Sleep(5000);
            Menu();
        }
    }
}
