using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            string filename = "Text.txt";
            File.AppendAllText(filename, $"{text}");
        }
    }
}
