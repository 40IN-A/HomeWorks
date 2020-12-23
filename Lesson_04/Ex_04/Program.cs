using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение последовательности вычисляющее число Фибоначчи:");
            long n = Convert.ToInt64(Console.ReadLine());

            long Number = Fibonacci(n);
            Console.WriteLine(Number);
        }
        static long Fibonacci (long n)
        {
            if (n == 0 )
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
