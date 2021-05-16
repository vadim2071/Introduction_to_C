using System;
using System.IO;

namespace task4
{

    /*Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
     
     Сделано с рекурсией*/
    class Program
    {
        static void Main(string[] args)
        {
            string FilePass = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\"; // путь для сохранения файла
            string filename = "task4.txt"; //имя файла для записи

            Console.WriteLine("Введите путь, для которого нужно записать дерево каталогов и файлов");
            string path = Console.ReadLine();

            if (!Directory.Exists(path)) Console.WriteLine("Ошибка! введенный путь не существует"); //проверка существования директории


            File.WriteAllText(FilePass + filename, "Дерево каталога " + path); // создаем / очищаем существующий файл для записи дерева

            WriteListDir(path, FilePass + filename);



            static void WriteListDir(string path, string file) // path - текущая директория, для которой строим дерево в этом вызове, file - путь и имя файла, куда записываем результат
            {
                string [] ListDir = Directory.GetDirectories(path); //получаем список массив вложенных каталогов в текущем каталоге

                for (int i = 0; i < ListDir.Length; i++)
                {
                    File.AppendAllText(file, Environment.NewLine);
                    File.AppendAllText(file, ListDir[i]);
                    WriteListDir(ListDir[i], file);
                }

                string[] ListFile = Directory.GetFiles(path); //получаем список файлов в текущем каталоге
               
                for (int i = 0; i < ListFile.Length; i++)
                {
                    File.AppendAllText(file, Environment.NewLine);
                    File.AppendAllText(file, ListFile[i]);
                }

                return;
            }
            

        }
    }
}
