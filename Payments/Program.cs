using System;

namespace Payments
{
    partial class Program
    {
        /*  public static void Main(String[] args)
         {

             Console.Clear();
             Console.WriteLine("Hello world");
             using (var pagamento = new Pagamento())
             {
                 Console.WriteLine("Processando pagamento...");
             }
             Console.ReadKey();
             Console.Clear();

             var numA = new Pessoa(1, "Caio F");
             var numB = new Pessoa(1, "Caio F");

             Console.WriteLine(numA.Equals(numB));

         } */

        class Pagamento : IPagamento//Class pai
        {
            public DateTime Vencimento { get; set; }

            public Pagamento()
            {
                Console.WriteLine("Iniciando pagamento");
            }
            //Método
            public virtual void Pagar() { }

            public void Dispose()
            {
                Console.WriteLine("Finalizado pagamento");
            }
        }

        class PagamentoBoleto : Pagamento //Herança - class filha
        {
            //prop
            public DateTime Venciomento { get; set; }

            //propg - Mais avançado
            public int Cpf { get; private set; }

            //propfull
            private DateTime _dataPagamenot;
            public DateTime DataPagamento
            {
                get
                {
                    Console.WriteLine(" Lendo o valor");
                    return _dataPagamenot;
                }
                set
                {
                    Console.WriteLine("Atribuindo valor");
                    _dataPagamenot = value;
                }
            }


            public override void Pagar()
            {
                // Regaras aplicada apenas ao NumeroBoleto
                base.Pagar();

            }
        }

        class CartaoCredito : Pagamento
        {


            public override void Pagar()
            {
                // Regras do Cartao de Credito
                base.Pagar();
            }
        }

        public interface IPagamento : IDisposable
        {
            DateTime Vencimento { get; set; }

            public void Pagar();

            public new void Dispose();


        }

    }
}