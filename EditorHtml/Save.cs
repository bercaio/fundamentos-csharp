using System;

namespace EditorHtml
{
    public static class Save
    {
        public static void Show(string text)
        {
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>");
            Console.Write("Nome que deseja salvar: ");
            string namePath = Console.ReadLine();
            var path = @"C:\Cursos\dotnet\Arquivos\" + namePath + ".txt";

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"'{path}'\n salvo!");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>");
            Console.ReadLine();
            Menu.Show();
        }


    }
}