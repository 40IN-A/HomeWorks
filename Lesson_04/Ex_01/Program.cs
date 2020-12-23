using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    class Program
    {
        
        static string GetFullName(string firstName, string patronymic, string lastName)
        {
            return $"Полное ФИО: {lastName} {firstName} {patronymic}";
        }

       
        static void Main(string[] args)
        {
            for ( int i = 0; i < 4; i ++)
            {
                Console.WriteLine("Введите имя: ");
                string firstName = Console.ReadLine();

                Console.WriteLine("Введите отчество:");
                string patronymic = Console.ReadLine();

                Console.WriteLine("Введите фамилию:");
                string lastName = Console.ReadLine();

                string sGetFullName = GetFullName(firstName, patronymic, lastName);
                Console.WriteLine(sGetFullName);
            }
             
              
            

        }
    }
}
