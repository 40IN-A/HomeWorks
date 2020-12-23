using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите набор чисел разделенных пробелом:");
            string str = Console.ReadLine();
            int[] arr = str.Split(new char[]{' ', ' '},StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToInt32(n)).ToArray();
            int sum = arr.Sum();
            /*
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];             
            }
            */
            Console.WriteLine($"Сумма элементов массива равна: {sum}");
            

        }
    }
}
