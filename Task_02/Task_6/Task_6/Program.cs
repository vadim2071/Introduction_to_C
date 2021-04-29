using System;

namespace Task_6
{
    class Program
    {
        [Flags]
        enum DayWeek
        {
            Mon   = 0b_0000001,
            Tue   = 0b_0000010,
            Wed   = 0b_0000100,
            Thu   = 0b_0001000,
            Fri   = 0b_0010000,
            Sat   = 0b_0100000,
            Sun   = 0b_1000000,
            WorkDay = 0b_0011111,
            Weekend = 0b_1100000
        }
        static void Main(string[] args)
        {
       
            //дни  работы Фирма 1
            
            DayWeek FirmFirst = DayWeek.Mon | DayWeek.Thu | DayWeek.Wed;

            //дни  работы Фирма 2
            DayWeek FirmSecond = DayWeek.Sat | DayWeek.Sun;

            //дни  работы Фирма 3
            DayWeek FirmThird = DayWeek.Mon | DayWeek.Thu | DayWeek.Wed | DayWeek.Thu | DayWeek.Fri | DayWeek.Sat;

            Console.WriteLine("по какой организации вы хотите узнать дни работы \n 1. фирма № 1 \n 2. Фирма № 2 \n 3. Фирма № 3");
            
            DayWeek TypeDay = DayWeek.Weekend;
            
            int Firm;
            Firm = Convert.ToInt32(Console.ReadLine());
            if (Firm == 1)
            {
                Console.WriteLine($"Фирма 1 работает по {FirmFirst}");
                TypeDay = FirmFirst;
            }
            else
            {
                if(Firm == 2)
                {
                    Console.WriteLine($"Фирма 2 работает по {FirmSecond}");
                    TypeDay = FirmSecond;
                }
                else
                {
                    if (Firm == 3)
                    {
                        Console.WriteLine($"Фирма 3 работает по {FirmThird}");
                        TypeDay = FirmThird;
                    }
                }
            }

            if ((((TypeDay & DayWeek.WorkDay) != 0) && ((TypeDay & DayWeek.Weekend)) != 0))
            {
                Console.WriteLine("Это рабочие и выходные дни");
            }
            else
            {
                if ((TypeDay & DayWeek.Weekend) != 0)
                {
                    Console.WriteLine("Это выходные дни");
                }
                else
                {
                    if ((TypeDay & DayWeek.WorkDay) != 0)
                    {
                        Console.WriteLine("Это рабочии дни");
                    }
                }
            }

        }
    }
}
