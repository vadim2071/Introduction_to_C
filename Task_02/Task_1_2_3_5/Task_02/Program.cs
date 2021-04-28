using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            float t_min;        // минимальная температур
            float t_max;        // максимальная температура
            float t_average;    // средняя температура
            int MonsNum;        // порядковый номер месяца
            string MonsName = "не возможно определить";    // название месяца

            Console.WriteLine("Введите минимальную температуру за сутки");
            t_min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            t_max = Convert.ToInt32(Console.ReadLine());

            if (t_min > t_max)
            {
                Console.WriteLine("Ошибка! Минимальная температура больше максимальной");
                return;
            }

            t_average = (t_min + t_max) / 2;

            Console.WriteLine($"Средняя температура {t_average}");
            Console.WriteLine("Введите порядковый номер месяца");
            MonsNum = Convert.ToInt32(Console.ReadLine());

            if (MonsNum % 2 == 0)
            {
                Console.WriteLine("Это четное число");
            }
            else
            {
                Console.WriteLine("Это нечетное число");
            }

            switch (MonsNum)
            {
                case 1:
                    {
                        MonsName = "Январь";
                        break;
                    }
                case 2:
                    {
                        MonsName = "Февраль";
                        break;
                    }
                case 3:
                    {
                        MonsName = "Март";
                        break;
                    }
                case 4:
                    {
                        MonsName = "Апрель";
                        break;
                    }
                case 5:
                    {
                        MonsName = "Май";
                        break;
                    }
                case 6:
                    {
                        MonsName = "Июнь";
                        break;
                    }
                case 7:
                    {
                        MonsName = "Июль";
                        break;
                    }
                case 8:
                    {
                        MonsName = "Август";
                        break;
                    }
                case 9:
                    {
                        MonsName = "Сентябрь";
                        break;
                    }
                case 10:
                    {
                        MonsName = "Октябрь";
                        break;
                    }
                case 11:
                    {
                        MonsName = "Ноябрь";
                        break;
                    }
                case 12:
                    {
                        MonsName = "Декабрь";
                        break;
                    }
            };

            Console.WriteLine($"Этот месяц {MonsName}");

            if (t_average > 0 && ((MonsNum == 12) || (MonsNum == 1) || (MonsNum == 2)))
            {
                Console.WriteLine("Это было дождливая зима");
            }
        }
    }
}
