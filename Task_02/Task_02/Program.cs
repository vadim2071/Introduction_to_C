using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            float t_min;        // минимальная температур
            float t_max;        // максимальная температура
            int MonsNum;        // порядковый номер месяца
            //string MonsName;    // название месяца

            Console.WriteLine("Введите минимальную температуру за сутки");
            t_min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            t_max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Средняя температура " + (t_min + t_max) / 2);

            Console.WriteLine("Введите порядковый номер месяца");
            MonsNum = Convert.ToInt32(Console.ReadLine());
            if (MonsNum == 1)
            {
                Console.WriteLine("Это Январь");
            }
            else
            {
                if (MonsNum == 2)
                {
                    Console.WriteLine("Это Февраль");
                }
                else
                {
                    if (MonsNum == 3)
                    {
                        Console.WriteLine("Это Март");
                    }
                    else
                    {
                        if (MonsNum == 4)
                        {
                            Console.WriteLine("Это Апрель");
                        }
                    }
                }
            }
                
        }
    }
}
