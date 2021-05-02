using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] RefBook = new string [5, 2];
            string Name;
            bool good = false;

            Console.WriteLine("Предлагаю заполнить телефонный справочник");

            for (int i=0; i<5; i++)
            {
                Console.WriteLine($"Введите имя контакта № {i+1}");
                RefBook[i, 0] = Console.ReadLine();
                Console.WriteLine($"Введите номер телефона для {RefBook[i,0]}");
                RefBook[i, 1] = Console.ReadLine();
            }

            Console.WriteLine($"Введите имя и я скажу его номер \nдля выхода из справочника введите - Stop");
            Name = Console.ReadLine();

            while (Name != "Stop")
            {
                good = false;

                for (int i=0; i<5; i++)
                {
                    if (RefBook[i,0] == Name)
                    {
                        Console.WriteLine($"Номер телефона {RefBook[i,0]} - {RefBook[i,1]}");
                        i = 5;
                        good = true;
                    }
                 
                }
                if (!good)
                {
                    Console.WriteLine($"Такого имени в справочнике нет");
                }
                Console.WriteLine($"Введите имя и я скажу его номер \nдля выхода из справочника введите - Stop");
                Name = Console.ReadLine();
            }
        }
    }
}
