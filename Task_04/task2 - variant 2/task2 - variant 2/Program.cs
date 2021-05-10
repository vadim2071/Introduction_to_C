using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Написать программу, принимающую на вход строку — набор чисел, 
               разделенных пробелом, и возвращающую число — сумму всех чисел в строке. 
               Ввести данные с клавиатуры и вывести результат на экран.*/
            Console.WriteLine("Привет! Введите группу чисел через пробел");
            string NumGroup = Console.ReadLine(); // получаем строчку
            int LenghtGroup = NumGroup.Length; //длина строки
            int sum = 0; // сумма
            int poz = 0; // текущая позиция в строке, с которой происходит обработка
            int num = 0; // промежуточная переменная для вычисления суммы
            while (poz < LenghtGroup)
            {
                (num, poz) = GetNumber(NumGroup, LenghtGroup, poz);
                sum = sum + num;
                poz++;
            }
            Console.WriteLine(sum);
        }


        // NumGroup - строка для разбора, lenght - длина строки,
        // poz - позиция с которой надо начинать/продолжать разбор строки
        static (int num, int poz) GetNumber(string NumGroup, int lenght, int poz)
        {
            string Number = "";
            
            //перебираем строку пока не дойдем до конца строки или до разделителя - пробел
            while (poz < lenght)
            {
                if (NumGroup[poz] == ' ') break;
                Number = Number + NumGroup[poz];
                poz++;
            }

            //возвращаем числовое значение и позицию где закончился разбор строки
            return (Convert.ToInt32(Number), poz);
        }
    }
}