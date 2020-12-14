using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое целое число:");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 != 0)
                Console.WriteLine("Вы ввели нечетное число!");
            else
                Console.WriteLine("Вы ввели четное число!");

        }
    }
}
