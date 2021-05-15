using System;
using System.Diagnostics;

/*Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и 
  позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов с помощью 
  указания его ID или имени процесса. В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill*/


namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            string select; // для хранения введенного имени процесса или Id процесса
            Process NameProc; //Имя процесса который собираемся завершить
            Process IdProc; // Id процесса который собираемся завершить

            Console.WriteLine("СПИСОК ЗАПУЩЕННЫХ ПРОЦЕССОВ");
            foreach (Process process in Process.GetProcesses("."))
            {
                Console.WriteLine("ID: {0} \t Name: {1}", process.Id, process.ProcessName);
            }
            
            
            Console.WriteLine("Введите номер или имя процесса который вы хотите завершить.");
            select = Console.ReadLine();

            
            if (isDigits(select))
            {
                try
                {
                    IdProc = Process.GetProcessById(Convert.ToInt32(select));
                    Console.WriteLine("работа процесса {0} завершена", IdProc.ProcessName);
                    IdProc.Kill();
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода номера процесса");
                }
            }
            else
            {
                try
                {
                    NameProc = Process.GetProcessesByName(select)[0];
                    /*честно, это решение подглядел в интернете, но так и не смог разобраться почему именно так должно быть ( я про [0] )
                      без [0] сообщает об ошибке CS0029	Cannot implicitly convert type 'System.Diagnostics.Process[]' to 'System.Diagnostics.Process'
                      по ошибке понятно, что не совпадают типы. но в описании метода GetProcessesByName написано про аргумент типа string или я что-то пропустил
                    */
                    Console.WriteLine("работа процесса {0} завершена", NameProc.ProcessName);
                    NameProc.Kill();
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода имени процесса");
                }
            }
            
                  
            
            bool isDigits(string str) // метод проверяет строка это набор цифр
            {
                if (str == null || str == "") return false;

                for (int i = 0; i < select.Length; i++)

                    if (str[i] < '0' || str[i] > '9')
                        return false;
                
                return true;
            }
        }
            

            
        
    }
}
