using System;

namespace task_dop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, вычисляющую число Фибоначчи для заданного значения 
             * рекурсивным способом. */
            Console.WriteLine("Привет! Введите длину полседовательност чисел Фибоначчи");

            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"число фибоначи {GetFibonachi(0, 1, num - 2)}");
        }

        static int GetFibonachi(int num1, int num2, int count)
        {
            if (count > 0)
            {
                return GetFibonachi(num2, num1 + num2, count - 1);
            }
            else
            {
                return num2;
            }
        }
    }
}
