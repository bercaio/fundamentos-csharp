using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Clear();
            // Data();
            // Culturas();
            // ZonaTempo();
            Timespan();
        }

        public static void Data()
        {
            var data = new DateTime(); // Structs - onde nao é defida como null, tem sempre um valor\
            var nowData = DateTime.Now.AddMonths(-1); // Data atual do dia.


            Console.WriteLine(data);
            // Console.WriteLine(nowData.AddMonths(+12)); // forma correta de somar as datas


            if (nowData < DateTime.Now.Date)
                Console.Write("É igual: ");

            Console.Write(nowData);

        }
        public static void Culturas()
        {
            var br = new CultureInfo("pt-BR");
            var enUS = new CultureInfo("en-US");
            var atual = CultureInfo.CurrentCulture; // Pega a Cultura em que a Maquina esta rodando

            Console.WriteLine(DateTime.Now.ToString("D", atual));
            Console.WriteLine(DateTime.Now.ToString("D", enUS));
            Console.WriteLine(DateTime.Now.ToString("D", br));
        }

        public static void ZonaTempo()
        {
            var utcData = DateTime.UtcNow;

            Console.WriteLine(utcData);
            Console.WriteLine(utcData.ToLocalTime());

            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timeZoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcData, timeZoneAustralia);
            Console.WriteLine(horaAustralia);
            Console.WriteLine("<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>");

            var timeZones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timeZone in timeZones)
            {
                Console.WriteLine(timeZone.Id);
                Console.WriteLine(timeZone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcData, timeZone));
                Console.WriteLine("------------------");
            }





        }

        public static void Timespan()
        {
            var timeHrMinSec = new TimeSpan(20, 30, 2);

            Console.WriteLine(timeHrMinSec);
        }
    }
}
