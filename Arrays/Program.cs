using System;


namespace Arrays
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.Clear();
            // ArrayFor();
            // ArrayForeach();
            ArrayStruct();

        }

        public static void ArrayFor()
        {
            var index = new int[5] { 1, 2, 3, 4, 5 };

            for (var list = 0; list < index.Length; list++)
            {

                Console.WriteLine(index[list]++);
            }
        }

        public static void ArrayForeach()
        {
            var indexs = new int[5];
            // indexs[0] = 1;
            Console.WriteLine(indexs[0]);
            var contIndex = indexs.Length;

            foreach (var index in indexs)
            {
                Console.WriteLine(indexs[index]++);
            }


        }

        public static void ArrayStruct()
        {

        }

    }
}