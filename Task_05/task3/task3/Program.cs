using System;
using System.Collections.Generic;
using System.IO;

//Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "task3.bin"; //имя файла для записи
            //переменная для хранения пути до файла на рабочем столе
            string FilePass = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";

            Console.WriteLine("Введите количество чисел, котрые вы србираетесь вводить");
            int num = Convert.ToInt32(Console.ReadLine());
            byte[] data = new byte[num]; // массив для хранения введеных даннных

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Осталось ввести {num-i} чисел. Введите произвольное число (0...255)");
                data[i] = Convert.ToByte(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine($"сейчас в файл {filename} запишется введенная последовательность");

            File.WriteAllBytes(FilePass + filename, data);
        }
    }
}