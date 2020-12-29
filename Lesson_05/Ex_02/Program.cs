using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "Startup.txt";
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            File.AppendAllText(filename, $"{text}");
            var date = DateTime.Now.ToString("HH:mm:ss");
            File.AppendAllLines(filename, new[] { $"\n{date}" });
        }
    }
}
