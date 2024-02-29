using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    interface ITwoDimensionalArray : IBaseArray
    {

    }

    sealed class TwoDimensionalArray<T> : ITwoDimensionalArray
    {
        private T[,] array;

        public T[,] Array { get => array; set => array = value; }

        public TwoDimensionalArray(int columns, int rows, bool fillKeyboard = false)
        {
            array = new T[rows, columns];

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
                    if (typeof(T) == typeof(int))
                    {
                        array[x, y] = (T)(object)random.Next(0, 10);
                    }
                    else if (typeof(T) == typeof(double))
                    {
                        array[x, y] = (T)(object)random.NextDouble();
                    }
                    else if (typeof(T) == typeof(bool))
                    {
                        if (random.Next(0, 2) == 0)
                            array[x, y] = (T)(object)false;
                        else array[x, y] = (T)(object)true;
                    }
                    else if (typeof(T) == typeof(string))
                    {
                        array[x, y] = (T)(object)("Q" + random.Next(0, 10).ToString());
                    }
                }
            }
        }


        // Метод заполнения массива с клавиатуры
        public void FillKeyboard()
        {
            Console.WriteLine("Ввод с клавиатуры:");
            Console.WriteLine("Тип данных: " + typeof(T));

            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    Console.Write($"[{x}, {y}] = ");

                    if (typeof(T) == typeof(int))
                    {
                        array[x, y] = (T)(object)Convert.ToInt32(Console.ReadLine());
                    }
                    else if (typeof(T) == typeof(double))
                    {
                        array[x, y] = (T)(object)Convert.ToDouble(Console.ReadLine());
                    }
                    else if (typeof(T) == typeof(bool))
                    {
                        array[x, y] = (T)(object)Convert.ToBoolean(Console.ReadLine());
                    }
                    else if (typeof(T) == typeof(string))
                    {
                        array[x, y] = (T)(object)Convert.ToString(Console.ReadLine());
                    }
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
    }
}
