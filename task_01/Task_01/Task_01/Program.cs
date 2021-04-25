using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            var UserName = Console.ReadLine();
            Console.WriteLine($"Привет, {UserName}, сегодня {DateTime.Today.ToLongDateString()}");
        }
    }
}
