using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String droW = "";
            string Word;

            Console.WriteLine("Привет! поиграем? Введите слово, а я его напишу наооборот.\nЕсли вам надоест введите слов Stop");
            Word = Console.ReadLine();

            while (Word != "Stop")
            {
                droW = droW + Word[Word.Length - 1];
                for (int i = Word.Length - 1; i != 0; i--)
                {
                    droW = droW + Word[i-1];
                }
                
                Console.WriteLine(droW);
                Console.WriteLine("Введите следующее слово, а я его напишу наооборот.\nЕсли вам надоест введите слов Stop");
                Word = Console.ReadLine();
                droW = "";
            }


        }
    }
}
