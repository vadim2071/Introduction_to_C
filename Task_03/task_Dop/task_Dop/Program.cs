using System;
/* Сделано: 
  1. заполнение массива символом 'O'
  2. вывод массва на экран
  3. случайное расположение 4-х клеточного корабля с проверко выхода за границы массива
  4. начато случайное расположпение двух 3-х клеточых с проверкой выхода за границы массива 
    и проверкой соприкосновения с уже установленным кораблем. из пункта 4 реализовано только
    проверка выхода за границы массива и частично проверка соприкосновения
*/
namespace task_Dop
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] Battlefield = new char[10,10];
            string Stroke = "";

            //заполняем первоначальными значениями "O"
            for (int x1 = 0; x1 < 10; x1++)
            {
                for (int y1 = 0; y1 < 10; y1++)
                {
                    Battlefield[x1, y1] = 'O';
                }
            }

            /*Генерация кораблей
            4 клетки - 1шт.
            3 клетки - 2 шт.
            2 клетки - 3 шт.
            1 клетки - 4 шт.
            */

            int x; //координата x, значение 0 - 9
            int y; // координата y, значение 0 - 9
            int direct; /*направление карабля, значения 
                         1 - налево, 
                         2 - направо, 
                         3 - вверх, 
                         4 - вниз*/
            bool success = false; // успех создания корабля
            Random rnd = new Random(); // для генерации случайной комбиеации

            //генерируем корабль 4 клетки

            while (!success)
            {
                // генерируем случайную ячейку и направление
                x = rnd.Next(0, 9);
                y = rnd.Next(0, 9);
                direct = rnd.Next(1, 4);

                //проверяем упираемся ли в стенку
                switch (direct)
                {
                    case 1:
                        {
                            //проверяем упрется ли корабль в левую стенку
                            if ((x - 4) > 0)
                            {
                                success = true;
                                //рисуем корабль
                                for (int i = 0; i < 4; i++)
                                {
                                    Battlefield[x - i, y] = 'X';
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            if ((x + 4) < 9)
                            {
                                success = true;
                                
                                for (int i = 0; i < 4; i++)
                                {
                                    Battlefield[x + i, y] = 'X';
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            if ((y - 4) > 0)
                            {
                                success = true;

                                for (int i = 0; i < 4; i++)
                                {
                                    Battlefield[x, y - i] = 'X';
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            if ((y + 4) < 9)
                            {
                                success = true;

                                for (int i = 0; i < 4; i++)
                                {
                                    Battlefield[x, y + i] = 'X';
                                }
                            }
                            break;
                        }
                }

            }

            //генерируем два корабля 3 клетки

            for (int n = 1; n < 3; n++)
            {
                success = false;

                while (!success)
                {
                    // генерируем случайную ячейку и направление
                    x = rnd.Next(0, 9);
                    y = rnd.Next(0, 9);
                    direct = rnd.Next(1, 4);

                    //проверяем упираемся ли в стенку или в другой корабль
                    switch (direct)
                    {
                        case 1: // направлние влево
                            {
                                //проверяем касается ли новый корабль уже установленного
                                for (int q = 0; q < 3; q++)
                                {
                                    if (y - 1 >= 0) //проверяем выход за границы массива
                                    {
                                        if (Battlefield[x - q, y - 1] == 'X')
                                        {
                                            break;
                                        }
                                    }
                                    if (y + 1 >= 0) //проверяем выход за границы массива
                                    {
                                        if (Battlefield[x - q, y + 1] == 'X')
                                        {
                                            break;
                                        }
                                    }
                                }
                                //проверяем упрется ли корабль в левую стенку
                                if ((x - 3) > 0)
                                {
                                    success = true;
                                    //рисуем корабль
                                    for (int i = 0; i < 3; i++)
                                    {
                                        Battlefield[x - i, y] = 'X';
                                    }
                                }
                                break;
                            }
                        case 2:
                            {
                                //проверяем касается ли новый корабль уже установленного
                                for (int q = 0; q < 3; q++)
                                {
                                    if (y - 1 >= 0) //проверяем выход за границы массива
                                    {
                                        if (Battlefield[x + q, y - 1] == 'X')
                                        {
                                            break;
                                        }
                                    }
                                    if (y + 1 >= 0) //проверяем выход за границы массива
                                    {
                                        if (Battlefield[x + q, y + 1] == 'X')
                                        {
                                            break;
                                        }
                                    }
                                }
                                if ((x + 3) < 9)
                                {
                                    success = true;

                                    for (int i = 0; i < 3; i++)
                                    {
                                        Battlefield[x + i, y] = 'X';
                                    }
                                }
                                break;
                            }
                        case 3:
                            {
                                if ((y - 3) > 0)
                                {
                                    success = true;

                                    for (int i = 0; i < 3; i++)
                                    {
                                        Battlefield[x, y - i] = 'X';
                                    }
                                }
                                break;
                            }
                        case 4:
                            {
                                if ((y + 3) < 9)
                                {
                                    success = true;

                                    for (int i = 0; i < 3; i++)
                                    {
                                        Battlefield[x, y + i] = 'X';
                                    }
                                }
                                break;
                            }
                    }

                }

            }

            

            //вывод содержимого массива на экран
            for (int x1 = 0; x1 < 10; x1++)
            {
                for (int y1 = 0; y1 < 10; y1++)
                {
                    Stroke = Stroke + " " + Battlefield[x1, y1];
                }
                Console.WriteLine(Stroke);
                Stroke = "";
            }

        }
    }
}
