using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    interface ITwoDimensionalArray : IBaseArray
    {
        void Reverse();

    }

    sealed class TwoDimensionalArray : ITwoDimensionalArray
    {
        private int[,] array;

        public int[,] Array { get => array; set => array = value; }

        public TwoDimensionalArray(int columns, int rows, bool fillKeyboard = false)
        {
            array = new int[rows, columns];

            if (fillKeyboard == true)
            {
                FillKeyboard();
            }
            else FillRandom();
        }

        // Метод заполнения массива случайными числами
        public void FillRandom()
        {
            Random random = new Random();
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    array[x, y] = random.Next(0, 10);
                }
            }
        }

        // Метод заполнения массива с клавиатуры
        public void FillKeyboard()
        {
            Console.WriteLine("Ввод с клавиатуры:");

            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    Console.Write($"[{x}, {y}] = ");
                    array[x, y] = int.Parse(Console.ReadLine());
                }
            }

        }

        // Метод вывода массива на экран
        public void Print()
        {
            Console.WriteLine("Вывод массива:");

            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    Console.Write(array[x, y] + " ");
                }
                Console.WriteLine(" ");
            }

        }
        public void Middle()
        {
            Console.WriteLine("Среднее значение");
            int r = 0;
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    r += array[x, y];
                }
            }
            int q = array.GetLength(0) * array.GetLength(1);
            Console.WriteLine(r / q);
        }

        public void Reverse()
        {
            Console.WriteLine("Если строка четная, то выводим с конца");
            int r = 0;
            for (int x = 0; x < array.GetLength(0); x++)
            {
                if (x % 2 != 0)
                {
                    for (int y = 0; y < array.GetLength(1) / 2; y++)
                    {
                        r = array[x, y];
                        array[x, y] = array[x, array.GetLength(1) - y - 1];
                        array[x, array.GetLength(1) - y - 1] = r;
                    }
                }
            }
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    Console.Write(array[x, y] + " ");
                }
                Console.WriteLine(" ");
            }

        }

        
    }
}
