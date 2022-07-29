
using System;
using MyApp.ContentContext;
using MyApp.SharedContext;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();

            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "fundamentos-csharp"));

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", null);
            var careerItem3 = new CareerItem(3, "Aprenda C#", "", courseCsharp);
            var careerItem2 = new CareerItem(2, "Aprenda ASP.NET", "", courseAspNet);

            careerDotNet.Items.Add(careerItem);
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem3);

            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Ordem))
                {
                    Console.WriteLine($"{item.Ordem} - {item.Title} -  {item.Course?.Title}");

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }
        }
    }
}