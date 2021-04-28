using System;

namespace Task_6
{
    class Program
    {
        public enum DayWeek
        {
            Mondey      = 0b0000001,
            Tuesday     = 0b0000010,
            Wednesday   = 0b0000100,
            Thursday    = 0b0001000,
            Friday      = 0b0010000,
            Saturday    = 0b0100000,
            Sunday      = 0b1000000,
        }
        static void Main(string[] args)
        {
            //дни  работы Фирма 1
            DayWeek FirmFirst = (DayWeek)0b0011110;

            //дни  работы Фирма 2
            DayWeek FirmSecond = DayWeek.Mondey | DayWeek.Thursday | DayWeek.Wednesday | DayWeek.Thursday | DayWeek.Friday | DayWeek.Saturday | DayWeek.Sunday;

            //дни  работы Фирма 3
            DayWeek FirmThird = DayWeek.Mondey | DayWeek.Thursday | DayWeek.Wednesday | DayWeek.Thursday | DayWeek.Friday | DayWeek.Saturday | DayWeek.Sunday;

            Console.WriteLine("по какой организации вы хотите узнать дни работы \n 1. фирма № 1 \n 2. Фирма № 2 \n 3. Фирма № 3");

            int Firm;
            Firm = Convert.ToInt32(Console.ReadLine());
            if (Firm == 1)
            {
                Console.WriteLine($"Фирма 1 работает по {FirmFirst}");
            }
            else
            {
                if(Firm == 2)
                {
                    Console.WriteLine($"Фирма 2 работает по {FirmSecond}");
                }
                else
                {
                    if (Firm == 3)
                    {
                        Console.WriteLine($"Фирма 3 работает по {FirmThird}");
                    }
                }
            }

        }
    }
}
