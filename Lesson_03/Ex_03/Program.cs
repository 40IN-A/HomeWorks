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
            Console.WriteLine("Введите любое предложение: ");
            string Sentence = Console.ReadLine();
            for ( int j = (Sentence.Length) - 1; j >= 0; j--) // 1-й способ вывожу посимвольно с помощью цикла. 
            { 
                Console.WriteLine(Sentence[j]);
            }

            char[] SentenceRevers = Sentence.ToCharArray();  // 2-й способ преобразую строку в символьный массив, затем выполняю реверсирование массива. 
            Array.Reverse(SentenceRevers);
            Sentence = new string(SentenceRevers);
            Console.WriteLine(Sentence);
        }
    }
}
