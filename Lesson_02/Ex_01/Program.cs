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
            Console.WriteLine("Введите минимальную температуру за сутки.");
            float TempMin = float.Parse(Console.ReadLine());
            while (TempMin <= -100 || TempMin >= 100)   // Пытаюсь сделать что-то вроде проверки на достоверность данных.  
            { 
                Console.WriteLine("Думается вы привераете, таких температур нет на планете Земля! Пока.");
                return; // Т.к. не знаю, как сделать возврат к просьбе ввести температуру, тупо выхожу из программы))))
            }                
            Console.WriteLine("Введите максимальную температуру за сутки.");
            float TempMax = float.Parse(Console.ReadLine());
            while (TempMin <= -100 || TempMin >= 100 || TempMin > TempMax)
            {
                Console.WriteLine("Вы ввели некорректные данные! До свидания.");
                return; // И снова выхожу из программы))))
            }
            float TempAver = (TempMin + TempMax) / 2;
            Console.WriteLine($"Средняя температура = {TempAver}");
        }
    }
}
