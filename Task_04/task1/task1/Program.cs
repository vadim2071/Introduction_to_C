using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать метод 
            GetFullName(string firstName, string lastName, string patronymic), 
            принимающий на вход ФИО в разных аргументах и возвращающий объединённую 
            строку с ФИО. Используя метод, написать программу, 
            выводящую в консоль 3–4 разных ФИО.
             */
            
            Console.WriteLine("Сколько вы собираетесь ввести ФИО?");
            int Num = Convert.ToInt32(Console.ReadLine());

            string[,] FIO = new string [Num, 3]; //массив для хранения введенных ФИО

            // вводим ФИО
            for(int i = 0; i < Num; i++)
            {
                Console.WriteLine($"осталось ввести {Num - i} ФИО");
                Console.WriteLine("Введите имя");
                FIO[i, 0] = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                FIO[i, 1] = Console.ReadLine();
                Console.WriteLine("Введите отчество");
                FIO[i, 2] = Console.ReadLine();
            }

            //вывод объединенного результата
            Console.WriteLine("Вы ввели следующие данные");
            for (int i = 0; i < Num; i++)
            {
                Console.WriteLine(GetFullName(FIO[i, 0], FIO[i, 1], FIO[i, 2]));
            }

            // ниже второй вариант с выводом сразу после ввода данных

            /*
            string FirstName, LastName, Patronymic;

            while (Num > 0)
            {
                Console.WriteLine($"осталось ввести {Num} ФИО");
                Console.WriteLine("Введите имя");
                FirstName = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                LastName = Console.ReadLine();
                Console.WriteLine("Введите отчество");
                Patronymic = Console.ReadLine();

                Console.WriteLine("Вы ввели - " + GetFullName(FirstName,LastName,Patronymic));
                Num = Num - 1;
            }*/



        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return ($"{lastName} {firstName} {patronymic}");
        }
    }
}
