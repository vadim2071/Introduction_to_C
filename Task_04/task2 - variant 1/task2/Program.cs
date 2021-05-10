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
            string NumGroup = Console.ReadLine();
            int LenghtGroup = NumGroup.Length; //длина строки
            Console.WriteLine(GetNumber(NumGroup, LenghtGroup, 0));

        }


        // NumGroup - строка для разбора, lenght - длина строки,
        // poz - позиция с которой надо начинать/продолжать разбор строки
        static int GetNumber(string NumGroup, int lenght, int poz)
        {
            string Number = "0"; // для "сборки" числа, начальное значение 0 для случая если последний символ - пробел
            int sum = 0;

            //перебираем строку пока не дойдем до конца строки или до разделителя - пробел
            while (poz < lenght)
            {
                if (NumGroup[poz] == ' ') break;
                Number = Number + NumGroup[poz];
                poz++;
            }

            //переводим полученный набор чисел из строчного формата в числовое значение 
            sum = Convert.ToInt32(Number);

            //проверяем дошли ли мы до конца строки
            if (poz == lenght)
            {
                return sum;
            }
            else
            {
                //если не дошли до конца строки, разбираем строчку дальше
                sum = sum + GetNumber(NumGroup, lenght, poz + 1);
                return sum;
            }
        }
    }
}
