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
            
            Console.WriteLine("Введите длину нулевого ранга массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину первого ранга массива: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Наш массив: ");

            int[,] nums = new int[n, m];

            Random r = new Random();       // Заполняю массив случайными значениями от 0, но меньше 100.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    nums[i, j] = r.Next(100);
                    Console.Write($"{nums[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Главная диагональ массива: ");

            for (int i = 0; i < nums.GetLength(0); i++)  // Вывожу главную диагональ массива.
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if (i == j)
                        Console.Write($"{nums[i, j]} ");
                }
                Console.WriteLine();
            }
             
        }
    }
}
