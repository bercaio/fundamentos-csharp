using System;

namespace ExceptionS
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.Clear();
            TryCatch();


        }

        public static void TryCatch()
        {

            var arrs = new int[3];

            try // tente fazer isso
            {
                // for (var i = 0; i < 10; i++)
                //     Console.WriteLine(arrs[i]);
                TratarErro("");
            }
            catch (IndexOutOfRangeException ex) // Tratar o erro do mais espcifico para o mais generico 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Erro de IndexOfRangeExcption");
            }
            catch (ArgumentNullException ex) // Tratar o erro - Exception
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Nada de nulo, nada de vazio");
            }
            catch (MinhaException ex) // Tratar o erro - Exception
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Hora do erro:");
            }
            catch /* senao faça isso*/(Exception ex) // Tratar o erro - Exception
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Tratativa de erro acima");
            }
            finally
            {
                Console.WriteLine("Aqui é onde faz a finalizacao depois de passar todos os Catch");
            }
        }

        public static void TratarErro(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new MinhaException(DateTime.Now);
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }

            public DateTime QuandoAconteceu { set; get; }
        }

    }
}