using System;
using System.IO;
using System.Text.Json;

namespace task5
{
    class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }

        /*public ToDo()
        {

        }
        */

        //конструктор
        public ToDo(string title, bool isdone)
        {
            Title = title;
            IsDone = isdone;
        }
    }
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
            string FilePass = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\"; //переменная для хранения пути до файла на рабочем столе
            string filename = "tasks.json"; //имя файла для записи
            string MenuSelect = ""; //

            ToDo NewTask;

            PrintListToDo(FilePass + filename);

            while (MenuSelect != "q")
            {
                if (MenuSelect == "0")
                {
                    // получаем новую задачу
                    NewTask = GetNewTask();

                    // записываем в файл задачу
                    SaveTask(FilePass + filename, NewTask);

                } else
                {
                    // помечаем задачу выполненой
                }
                                
                Console.Clear();
                PrintListToDo(FilePass + filename); // выводим список задач
                MenuSelect = GetMenuSelect(); //запрашиваем что мы хотим сделать
            }
            
            

        }
        

        static void SaveTask(string file, ToDo task) // метод сериализации задач - task в файл - file
        {
            string json = JsonSerializer.Serialize(task);
            File.AppendAllText(file, Environment.NewLine);
            File.AppendAllText(file, json);
        }


        static void PrintListToDo(string file) //метод выводы списка задач на экран
        {
            if (File.Exists(file))
            {
                string [] json = File.ReadAllLines(file);
                Console.WriteLine("№ \t Выполнено \t Задача");
                ToDo Tasks;


                for (int i = 0; i < json.Length; i++)
                {
                    Tasks = JsonSerializer.Deserialize<ToDo>(json[i]);
                    Console.WriteLine("{0} \t {1} \t {2}", i, Tasks.IsDone, Tasks.Title);
                }

                
               
                
                
             }
            else
            {
                Console.WriteLine("Файл задач не найден, создан пустой список задач");
                File.Create(file);
            }
        }

        static string GetMenuSelect()         // метод выбора действия
        {
            Console.WriteLine("Ведите номер задачи для ее завершения или \n 0 - добавить задачу | q - закончить работу");
            return Console.ReadLine();
        }

        static ToDo GetNewTask()         // метод ввода новой задачи
        {
            Console.WriteLine("Введите задачу");
            string TaskName = Console.ReadLine();
            ToDo task = new ToDo(TaskName, false);
            return task;
        }
    }
}


