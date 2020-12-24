using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    class Program
    {
        
        enum Seasons
        {
            Winter = 1,
            Spring,
            Summer,
            Autumn
        }

        static int GetSeason(int i)
        {
            //Seasons s;
            switch (i)
            {
                case 1:
                    i = (int) Seasons.Winter;
                    break;
                case 2:
                    i = (int)Seasons.Winter;
                    break;
                case 3:
                    i = (int)Seasons.Spring;
                    break;
                case 4:
                    i = (int)Seasons.Spring;
                    break;
                case 5:
                    i = (int)Seasons.Spring;
                    break;
                case 6:
                    i = (int)Seasons.Summer;
                    break;
                case 7:
                    i = (int)Seasons.Summer;
                    break;
                case 8:
                    i = (int)Seasons.Summer;
                    break;
                case 9:
                    i = (int)Seasons.Autumn;
                    break;
                case 10:
                    i = (int)Seasons.Autumn;
                    break;
                case 11:
                    i = (int)Seasons.Autumn;
                    break;
                case 12:
                    i = (int)Seasons.Winter;
                    break;
                default:
                    Console.WriteLine("Вы ввели не верные данные.");
                    break;
            }
            return i;
        }
        static void Translation(int sGetSeason)
        {
            switch (sGetSeason)
            {
                case 1:
                    Console.WriteLine("Зима!");
                    break;
                case 2:
                    Console.WriteLine("Весна!");
                    break;
                case 3:
                    Console.WriteLine("Лето!");
                    break;
                case 4:
                    Console.WriteLine("Осень!");
                    break;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца:");
            int i = Convert.ToInt32(Console.ReadLine());
            int sGetSeason = GetSeason(i);
            Translation(sGetSeason);
            

        }
    }
}
