using System;

namespace task_Dop
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] Battlefield = new char[10,10];
            string Stroke = "";

            //заполняем первоначальными значениями "O"
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Battlefield[x, y] = 'O';
                }
            }

            //Генерация кораблей

            //вывод содержимого массива на экран
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Stroke = Stroke + Battlefield[x, y];
                }
                Console.WriteLine(Stroke);
                Stroke = "";
            }

        }
    }
}
