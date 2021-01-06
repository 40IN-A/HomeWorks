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
            Console.WriteLine("Введите слово:");
            string s1 = Console.ReadLine();
            char[] s2 = s1.ToCharArray();
            //Array.Reverse(s2);
            for(int i = s2.Length - 1; i >= 0; i--)
            Console.WriteLine(s2[i]);
        }
    }
}
