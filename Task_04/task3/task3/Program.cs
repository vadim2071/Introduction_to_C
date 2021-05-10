using System;

namespace task3
{
    class Program
    {
        [Flags]
        enum Season
        {
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4,
        }
        static void Main(string[] args)
        {
            /*Написать метод по определению времени года. 
             *На вход подаётся число – порядковый номер месяца. 
             *На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
             *Написать метод, принимающий на вход значение из этого перечисления и возвращающий
             *название времени года (зима, весна, лето, осень). 
             *Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени
             *года. Если введено некорректное число, 
             *вывести в консоль текст «Ошибка: введите число от 1 до 12».*/


            int mons = 0;
            Console.WriteLine("Привет! Введите номер месяца");

            while (mons < 1 || mons > 12)
            {
                mons = Convert.ToInt32(Console.ReadLine());

                if (mons < 1 || mons > 12)
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                }
            }


            Console.WriteLine(GetTranslate(GetSeason(mons)));

        }

        static Season GetSeason(int mons)
        {
            if(mons >= 3 & mons <= 5)
            {
                return Season.Spring;
            }
            else
            {
                if (mons >= 6 & mons <= 8)
                {
                    return Season.Summer;
                }
                else
                {
                    if (mons >= 9 & mons <= 11)
                    {
                        return Season.Autumn;
                    }
                    else return Season.Winter;
                }
            }
        }

        static string GetTranslate(Season NeedTranslate)
        {
            switch (NeedTranslate)
            {
                case Season.Autumn:
                    return "Осень";
                    break;

                case Season.Spring:
                    return "Весна";
                    break;

                case Season.Summer:
                    return "Лето";
                    break;

                case Season.Winter:
                    return "Зима";
                    break;

                default:
                    return "что-то пошло не так";
                    break;
            }
        }
    }
}
