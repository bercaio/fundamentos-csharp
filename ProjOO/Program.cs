using System;
using System.Linq;
using ProjOO.ContentContext;

namespace ProjOO
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Clear();

            var articles = new List<Article>();
            articles.Add(new Article("Artigo OOP", "orientacoa-objeto"));
            articles.Add(new Article("Artigo C#", "csharp"));
            articles.Add(new Article("Artigo .NET", "dotnet"));

            // foreach (var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            //     Console.WriteLine();
            // }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamento-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamento-csharp");
            var courseAspNet = new Course("Fundamentos ASP,NET", "fundamento-asp-net");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
            var careerItem = new CareerItem(1, "Comece aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem3);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Ordem))
                {
                    Console.WriteLine($"{item.Ordem} - {item.Title}");
                    Console.WriteLine(item.Course.Title);
                    Console.WriteLine(item.Course.Level);

                }

            }


        }
    }
}
