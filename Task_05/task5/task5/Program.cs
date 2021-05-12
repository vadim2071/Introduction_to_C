﻿using System;
using System.IO;
using System.Text.Json;

namespace task5
{
    class Program
    {
        /* Список задач (ToDo-list):
        - написать приложение для ввода списка задач;
        + задачу описать классом ToDo с полями Title и IsDone;
        - на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
        - если задача выполнена, вывести перед её названием строку «[x]»;
        - вывести порядковый номер для каждой задачи;
        - при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
        - записать актуальный массив задач в файл tasks.json/xml/bin.*/
        static void Main(string[] args)
        {
            string filename = "tasks.json"; //имя файла для записи
            //переменная для хранения пути до файла на рабочем столе
            string FilePass = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";

            if (File.Exists(FilePass + filename))
            {
                
            }

            //ToDo List1 = new ToDo();
        }
    }
}
