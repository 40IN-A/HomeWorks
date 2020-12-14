using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04
{
    class Program
    {
        enum Months
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца:");
            int i = Convert.ToInt32(Console.ReadLine());
            Months CurrentMonth = (Months)i;
            
            Console.WriteLine("Введите минимальную температуру за этот месяц.");
            float TempMin = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите максимальную температуру за этот месяц.");
            float TempMax = float.Parse(Console.ReadLine());
            float TempAver = (TempMin + TempMax) / 2;

            if ((i == 1 || i == 2 || i == 12) && TempAver > 0)
                Console.WriteLine("Дождливая зима!");
            else
                Console.WriteLine($"А {CurrentMonth} нынче неплохой!");

        }
    }
}
