using System;
using System.IO;

//Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "task1.txt"; //имя файла для записи
            string data; // перменная для хранения введеных даннных
            //переменная для хранения пути до файла на рабочем столе
            string FilePass = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
                        
            Console.WriteLine("Введите произвольный набор данных");
            data = Console.ReadLine();
            File.WriteAllText(FilePass + filename, data);
        }
    }
}
