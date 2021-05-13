using System;
using System.IO;
using System.Text.Json;

namespace task5
{
    class Program
    {
        /* Список задач (ToDo-list):
        - написать приложение для ввода списка задач;
        + задачу описать классом ToDo с полями Title и IsDone;
        - на старте, если есть файл tasks.json/xml/bin (выбрать формат), 
                        загрузить из него массив имеющихся задач и вывести их на экран;
        - если задача выполнена, вывести перед её названием строку «[x]»;
        - вывести порядковый номер для каждой задачи;
        - при вводе пользователем порядкового номера задачи отметить задачу с 
                        этим порядковым номером как выполненную;
        - записать актуальный массив задач в файл tasks.json/xml/bin.*/
        static void Main(string[] args)
        {
            string filename = "tasks.json"; //имя файла для записи
            string MenuSelect = "";
            ToDo NewTask;
            //переменная для хранения пути до файла на рабочем столе
            string FilePass = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            
            PrintListToDo(FilePass + filename);

            while (MenuSelect != "q")
            {
                if (MenuSelect == "0")
                {
                    // получаем новую задачу
                    NewTask = GetNewTask();

                    // тут надо записать в файл задачу
                } else
                {
                    // помечаем задачу выполненой
                }
                                
                Console.Clear();
                PrintListToDo(FilePass + filename); // выводим список задач
                MenuSelect = GetMenuSelect(); //запрашиваем что мы хотим сделать
            }
            
            

        }

        //метод выводы списка задач на экран
        static void PrintListToDo(string file)
        {
            if (File.Exists(file))
            {
                // тут надо вывести список задач
            }
            else
            {
                Console.WriteLine("Файл задач не найден, создан пустой список задач");
                File.Create(file);
            }
        }

        // метод выбора действия
        static string GetMenuSelect()
        {
            Console.WriteLine("Ведите номер задачи для ее завершения или \n 0 - добавить задачу | q - закончить работу");
            return Console.ReadLine();
        }

        // метод ввода новой задачи
        static ToDo GetNewTask()
        {
            Console.WriteLine("Введите задачу");
            string TaskName = Console.ReadLine();
            ToDo task = new ToDo(TaskName, false);
            return task;
        }
    }
}


