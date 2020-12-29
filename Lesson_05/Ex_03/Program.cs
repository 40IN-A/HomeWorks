using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите с клавиатуры произвольный набор чисел (0...250): ");
            string str = Console.ReadLine();
            byte[] arr = str.Split(new char[] { ' ', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToByte(n)).ToArray();
            FileStream file = new FileStream("Binari.dat", FileMode.Create, FileAccess.Write);
            BinaryWriter tr = new BinaryWriter(file);
            tr.Write(arr);
            tr.Close();
            file.Close();

            //Чтение файла.

            Console.WriteLine("Считываю массив из файла.");
            if (File.Exists("Binari.dat")) //Проверяю, существует ли файл Binari.dot, если да, то начинаю считывать.
            { 
            FileStream fileR = new FileStream("Binari.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fileR);
            for (int i = 0; i < arr.Length; i++)
                arr[i] = br.ReadByte();
            }
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine($"{arr[i]}");
            Console.ReadLine();
        }
    }
}
