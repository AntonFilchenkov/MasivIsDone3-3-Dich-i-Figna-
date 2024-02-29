using System;
namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter[] printObjects = new IPrinter[2];
            printObjects[0] = new OneDimensionalArray<int>(4, false);
            printObjects[1] = new TwoDimensionalArray<string>(4, 4, false);

            Console.WriteLine("Вывод объектов:");
            for (int i = 0; i < printObjects.Length; i++)
            {
                printObjects[i].Print();
            }

            Console.ReadLine();
        }
    }
}


