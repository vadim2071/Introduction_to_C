using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter you name");
            string name = Console.ReadLine();
            Console.WriteLine("How many age");
            string age = Console.ReadLine();

            Console.WriteLine($"Hello {name}! You are {age}");
            if (Convert.ToInt32(age) > 65)
            {
                Console.WriteLine("you pensioner?");
            }
            Console.WriteLine($"Do 100 let ostalos {100 - Convert.ToInt32(age)} let");
        }
    }
}
