using System;
using System.Globalization;

namespace Moedas
{
    class Progrma
    {
        public static void Main(String[] args)
        {
            Console.Clear();
            // TipoMoeda();
            // FormatMoeda();
            
        }

        static void TipoMoeda()
        {
            decimal valor = 10.34m; // Decimal, forma mais adequada de se usar com Moedas

            Console.Write(valor);
        }

        static void FormatMoeda()
        {
            decimal valor = 10548.23m;

            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); // Mo``stra com o $ (R$) da cultura especificada 
            Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR"))); // Mostra valor sem os pontos nas casas decimal
            Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR"))); // Mostra valor com pontos nas casas decimal
            Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR"))); // Mostra com o Porcentagem


            // foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.NeutralCultures))
            // {
            //     Console.Write("{0,-7}", ci.Name);
            //     Console.Write("{0,-3}", ci.TwoLetterISOLanguageName);
            //     Console.Write("{0,-3}", ci.ThreeLetterWindowsLanguageName);
            //     Console.WriteLine(" {0,-40}", ci.DisplayName);

            // }


        }
    }
}
