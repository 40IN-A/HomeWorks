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
            char[,] SeaBattle = new char[10, 10] { { 'O', 'X', 'X', 'X', 'O', 'O', 'X', 'X', 'O', 'O'},
                                                   { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                                                   { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                                                   { 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O'},
                                                   { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X'},
                                                   { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'X'},
                                                   { 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'X'},
                                                   { 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O'},
                                                   { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                                                   { 'O', 'X', 'X', 'O', 'O', 'X', 'X', 'O', 'O', 'O'} };

            Console.WriteLine("Двумерный массив в виде поля игры Морской бой, где 'X' - элементы кораблей.");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{SeaBattle[i, j]} \x020");
                }
                Console.WriteLine();
            }

        }
    }
}
