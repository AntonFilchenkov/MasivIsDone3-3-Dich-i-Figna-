using System;
namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            IBaseArray[] arrays = new IBaseArray[3];
           

            arrays[0] = new OneDimensionalArray(4, true);
            arrays[1] = new TwoDimensionalArray(4, 4, true);
            arrays[2] = new StepArray(new int[] { 1, 2, 3 }, true);
            IPrinter[] printObjects = new IPrinter[arrays.Length + 1];

            for (int i = 0; i < arrays.Length; i++)
            {
                printObjects[i] = arrays[i];
            }
            printObjects[printObjects.Length - 1] = new DaysOfWeek();


            Console.WriteLine("Задача с методом print:");
            for (int i = 0; i < printObjects.Length; i++)
            {
                printObjects[i].Print();
            }

            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] == null)
                    return;

                // arrays[i].Print();
                arrays[i].Middle();
                if (arrays[i] is OneDimensionalArray)
                {
                    OneDimensionalArray temp = (OneDimensionalArray)arrays[i];
                    temp.Minimal();
                    temp.Delete();
                }
                else if (arrays[i] is TwoDimensionalArray)
                {
                    TwoDimensionalArray temp = (TwoDimensionalArray)arrays[i];
                    temp.Reverse();
                }
                else if (arrays[i] is StepArray)
                {
                    StepArray temp = (StepArray)arrays[i];
                    temp.MidleOne();
                    temp.ReverseIndex();
                }
            }
            Console.ReadLine();
        }
    }
}

