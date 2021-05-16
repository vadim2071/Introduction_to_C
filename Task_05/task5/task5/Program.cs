using System;
using System.IO;
using System.Text.Json;

namespace task5
{
    class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }

        //конструктор
        public ToDo(string title, bool isdone)
        {
            Title = title;
            IsDone = isdone;
        }
    }
    class Program
    {
        // ВЕРСИЯ 2.
        // РЕАЛИЗАЦИЯ с использованием массивов, уменьшает количество операция чтения / записи в файл


        /* Список задач (ToDo-list):
        - написать приложение для ввода списка задач;
        + задачу описать классом ToDo с полями Title и IsDone;
        + на старте, если есть файл tasks.json/xml/bin (выбрать формат), 
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
            string MenuSelect = ""; // выбор действия
            ToDo[] ToDoList = { }; //массив для хранения всех задач
            ToDo Tasks; // для промежуточного хранения задач
            ToDo NewTask;

            if (!File.Exists(FilePass + filename)) File.Create(FilePass + filename).Close(); //проверяем существоание файла

            //читаем в массив все задачи из файла
            string[] jsonIN = File.ReadAllLines(FilePass + filename);
            for (int i = 0; i < jsonIN.Length; i++)
            {
                Tasks = JsonSerializer.Deserialize<ToDo>(jsonIN[i]);
                Array.Resize(ref ToDoList, ToDoList.Length + 1);
                ToDoList[i] = Tasks;
            }

            PrintListToDo(ToDoList); //выводим список задач на экран первый раз

            while (MenuSelect != "q")
            {
                if (MenuSelect == "0")
                {
                    // вводим новую задачу
                    NewTask = GetNewTask();

                    // добавляем задачу
                    ToDoList = SaveTask(ToDoList, NewTask);
                }
                else
                {
                    if (MenuSelect != "")
                    {
                        ToDoList = EndTask(ToDoList, Convert.ToInt32(MenuSelect)); // помечаем задачу выполненой и получаем измененный массив с задачами
                    }
                }


                Console.Clear();
                PrintListToDo(ToDoList); // выводим список задач
                MenuSelect = GetMenuSelect(); //запрашиваем что мы хотим сделать
            }

            //Сохраняем результат в файл
            File.Create(FilePass + filename).Close();
            string jsonOut;

            jsonOut = JsonSerializer.Serialize(ToDoList[0]); // первая запись делается без добавления новой строки
            File.AppendAllText(FilePass + filename, jsonOut);

            for (int i = 1; i < ToDoList.Length; i++)
            {
                jsonOut = JsonSerializer.Serialize(ToDoList[i]);
                File.AppendAllText(FilePass + filename, Environment.NewLine);
                File.AppendAllText(FilePass + filename, jsonOut);
            }
            

        }

        static ToDo [] EndTask(ToDo [] ToDoList, int numTask) // метод завершения выбранной задачи.
        {
            ToDoList[numTask - 1].IsDone = true;
            return ToDoList;
        }

        static ToDo [] SaveTask(ToDo [] ToDoList, ToDo NewTask) // Добавляем в массив новую задачу
        {
            Array.Resize(ref ToDoList, ToDoList.Length + 1);
            ToDoList[ToDoList.Length - 1] = NewTask;
            return ToDoList;
        }

        static void PrintListToDo(ToDo [] ToDoList) //метод выводы списка задач на экран
        {
            char isdone = ' ';
            Console.WriteLine("№ \t Выполнено \t Задача");

            for (int i = 0; i < ToDoList.Length; i++)
            {
                if (ToDoList[i].IsDone) isdone = 'X';
                Console.WriteLine("{0} \t {1} \t \t {2}", i + 1, isdone, ToDoList[i].Title);
                isdone = ' ';
            }

        }

        static string GetMenuSelect()         // метод выбора действия
        {
            Console.WriteLine("Ведите номер задачи для ее завершения или \n 0 - добавить задачу | q - закончить работу и для сохранения результата");
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
