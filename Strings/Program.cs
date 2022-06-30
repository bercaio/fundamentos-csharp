using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(String[] args)
        {
            // Guids();
            // Comparcao();
            // Indices();
            // adicionais();
            Manipulacao();
            // Builders();

        }

        static void Guids()
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid();

            id = new Guid("6f27295f-8880-41e6-9425-58d1dc0de7a2");
            Console.WriteLine(id);
            // Console.WriteLine(id.ToString().Substring(0, 8));
        }

        static void Comparcao()
        {
            var texto = "Testa ate frase";

            // Console.WriteLine(texto.CompareTo("Teste")); //variacao entre 0 e 1;
            Console.WriteLine(texto.Contains("ate")); // identifica os char corresponde ao texto. com True or False;
            Console.WriteLine(texto.Contains("Frase", StringComparison.OrdinalIgnoreCase)); // Ignora se o tipo é maiusculo ou minusculo; 
            Console.WriteLine(texto.StartsWith("Testa"));
            Console.WriteLine(texto.EndsWith("Frase", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.Equals("Testa Ate Frase")); // Comprar objetos do mesmo tipo

        }

        static void Indices()
        {
            var text = "Em busca da letra perfect";

            Console.WriteLine(text.IndexOf("a")); // Primeiro char que achar pegando sempre o primero da palavra;
            Console.WriteLine(text.LastIndexOf("a")); //Ultimo char que achar, penado o primeiro da palvra;
        }

        static void adicionais()
        {
            var text = "Este é um texto qualqeur";

            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Insert(5, "aqui "));
            Console.WriteLine(text.Length);
        }

        static void Manipulacao()
        {
            var text = " Oq se foi fazer no mato maria_leao ";


            Console.WriteLine(text.Replace("a", "o"));


            var divisao = text.Split(" ");
            // Console.WriteLine(divisao[0]);
            // Console.WriteLine(divisao[1]);
            // Console.WriteLine(divisao[2]);
            // Console.WriteLine(divisao[3]);
            // Console.WriteLine(divisao[4]);
            // Console.WriteLine(divisao[5]);
            // Console.WriteLine(divisao[6]);


            Console.WriteLine(text.Remove(6, 3));
            Console.WriteLine(text.Substring(2, 1 + 4));

            Console.Write(text.Trim());
        }

        static void Builders()
        {
            var linhas = new StringBuilder();

            linhas.Append("Texto com ");
            linhas.Append("varias linhas ");
            linhas.Append("onde no final. ");
            linhas.Append("Ele  junta tudo, ");
            linhas.Append("usado qaundo se tem muitas linhas de codigo.");

            linhas.ToString();

            Console.WriteLine(linhas);
        }

    }
}