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
            string[,] phonebook = new string[2, 5] { { "Иванов Е.В.", "Сидоров П.Р.", "Петров В.И.", "Сергеев О.Л.", "Павлов Б.Ю." }, { "+71234567890 / ivanov@gb.ru", "+72345678901 / sidorov@gb.ru", "+73456789012 / petrov@gb.ru", "+74567890123 / sergeev@gb.ru", "+75678901234 / pavlov@gb.ru"} };
            for ( int i = 0; i < 5; i++) // Не использую "GetLength()" ибо наш массив строго определён.
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{phonebook[j, i]} \t"); 
                }
                Console.WriteLine();
            }
        }
    }
}
