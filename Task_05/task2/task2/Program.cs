using System;
using System.IO;

//Написать программу, которая при старте дописывает текущее время в файл «startup.txt».

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "task2.txt"; //имя файла для записи
            string time;
            //переменная для хранения пути до файла на рабочем столе
            string FilePass = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            time = DateTime.Now.ToLongTimeString();

            Console.WriteLine($"в файл {filename} сейчас запишем текущее время {time}");
            if (File.Exists(FilePass+filename))
            {
                File.AppendAllText(FilePass + filename, Environment.NewLine);
                File.AppendAllText(FilePass + filename, time);
            }
            else
            {
                File.WriteAllText(FilePass + filename, time);
            };
            
        }
    }
}