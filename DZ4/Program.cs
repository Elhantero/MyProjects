using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4
{
    class Program
    {
        static void Main()
        {
            var testResult = new LevelENG<string, string, string>(10);

            testResult.Add(0, "Максим", "Біловус", "A2");
            testResult.Add(1, "Юрій", "Горчук", "A2");
            testResult.Add(2, "Михайло", "Єфремов", "A2");
            testResult.Add(3, "Тетяна", "Ковблюк", "C1");
            testResult.Add(4, "Геннадій", "Кудра", "B1");
            testResult.Add(5, "Володимир", "Лаврентьєв", "A2");
            testResult.Add(6, "Олексій", "Матвійчук", "B1");
            testResult.Add(7, "Олександр", "Хоменко", "A2");
            testResult.Add(8, "Артур", "Фесенко", "B1");
            testResult.Add(9, "Олександр", "Цимбал", "B1");

            foreach (var item in testResult)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
