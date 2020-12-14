using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02
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
            Console.WriteLine(CurrentMonth);
        }
    }
}
