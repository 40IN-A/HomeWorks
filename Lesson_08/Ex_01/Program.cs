using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            if(string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            if(string.IsNullOrEmpty(Properties.Settings.Default.Age))
            {
                Console.WriteLine("Введите возраст:");
                Properties.Settings.Default.Age = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            if(string.IsNullOrEmpty(Properties.Settings.Default.SortOfActivity))
            {
                Console.WriteLine("Введите род деятельности:");
                Properties.Settings.Default.SortOfActivity = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            string userName = Properties.Settings.Default.UserName;
            string age = Properties.Settings.Default.Age;
            string sortOfActivity = Properties.Settings.Default.SortOfActivity;
            string greeting = Properties.Settings.Default.Greeting;

            Console.WriteLine($"{greeting}\n{sortOfActivity} {userName} {age} лет.");
        }
    }
}
