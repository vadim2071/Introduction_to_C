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
            int ProductQuantity01 = 5;
            int ProductQuantity02 = 5;
            int ProductQuantity03 = 2;
            double ProductPrice01 = 159.95;
            double ProductPrice02 = 90.95;
            double ProductPrice03 = 201.54;

            Console.WriteLine(DateTime.Now);
            Console.WriteLine("ИНН 2374569812437");
            Console.WriteLine("ООО Купите у нас все \n");

            Console.WriteLine("   {0, -18} {1, 7} {2, -5} {3, 6}", "Наименование ", "цена", "кол-во", "Сумма");

            Console.WriteLine("1. {0, -18} {1, 7} {2, 4} {3, 9}", ProductName01, ProductPrice01, ProductQuantity01, ProductQuantity01 * ProductPrice01);
            Console.WriteLine("2. {0, -18} {1, 7} {2, 4} {3, 9}", ProductName02, ProductPrice02, ProductQuantity02, ProductQuantity02 * ProductPrice02);
            Console.WriteLine("3. {0, -18} {1, 7} {2, 4} {3, 9}", ProductName03, ProductPrice03, ProductQuantity03, ProductQuantity03 * ProductPrice03);

            Console.WriteLine("--------------");
            Console.WriteLine("Итого {0,38} \n", (ProductQuantity01 * ProductPrice01) + (ProductQuantity02 * ProductPrice02) + (ProductQuantity03 * ProductPrice03));
            Console.WriteLine("СПАСИБО");
        }
    }
}
