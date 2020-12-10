using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now.ToString("dd.MM.yyyy")}");// Время не выводил, т.к. в задании просят вывести %дата%, я так понимаю для даты время не требуется.
            Console.ReadLine();
        }
    }
}
