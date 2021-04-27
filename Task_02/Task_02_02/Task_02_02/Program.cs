using System;

namespace Task_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string ProductName01 = "Лампочка 19 Вт";
            string ProductName02 = "Выключатель";
            string ProductName03 = "Розетка";
            int ProductNumber01 = 5;
            int ProductNumber02 = 5;
            int ProductNumber03 = 2;
            double ProdustPrice01 = 159.9;
            double ProdustPrice02 = 90.9;
            double ProdustPrice03 = 201.5;


            Console.WriteLine(DateTime.Today.ToLongDateString());
            Console.WriteLine($"1. {ProductName01} {ProductNumber01} {ProdustPrice01} {ProductNumber01 * ProdustPrice01}");
            Console.WriteLine($"2. {ProductName02} {ProductNumber02} {ProdustPrice02} {ProductNumber02 * ProdustPrice02}");
            Console.WriteLine($"3. {ProductName03} {ProductNumber03} {ProdustPrice03} {ProductNumber03 * ProdustPrice03}");
        }
    }
}
