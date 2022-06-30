using System;

namespace TesteInternet
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.Clear();
            Console.Write($"Qual o valor do primeiro taxi: ");
            double taxi1 = double.Parse(Console.ReadLine());
            Console.Write("\nQual o valor do segundo taxi: ");
            double taxi2 = double.Parse(Console.ReadLine());


            if (taxi1 < taxi2)
                Console.WriteLine("FRIST");
            else if (taxi1 > taxi2)
                Console.WriteLine("ANY");
            else
                Console.WriteLine("SECOND");




        }
    }

}