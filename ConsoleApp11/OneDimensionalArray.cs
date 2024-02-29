using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    interface IOneDimensionalArray : IBaseArray
    {

    }

    // Одномерный массив
    sealed class OneDimensionalArray<T> : IOneDimensionalArray
    {
        private T[] array;

        public T[] Array { get => array; set => array = value; }

        // true - заполнение с клавиатуры,
        // false - заполнение случайными
        public OneDimensionalArray(int length, bool fillKeyboard = false)
        {
            array = new T[length];

            if (fillKeyboard == true)
                FillKeyboard();
            else FillRandom();
        }

        // Метод заполнения массива случайными значениями
        public void FillRandom()
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                if (typeof(T) == typeof(int))
                {
                    array[i] = (T)(object)random.Next(0, 10);
                }
                else if (typeof(T) == typeof(double))
                {
                    array[i] = (T)(object)random.NextDouble();
                }
                else if (typeof(T) == typeof(bool))
                {
                    if (random.Next(0, 2) == 0)
                        array[i] = (T)(object)false;
                    else array[i] = (T)(object)true;
                }
                else if (typeof(T) == typeof(string))
                {
                    array[i] = (T)(object)("Q" + random.Next(0, 10).ToString());
                }
            }
        }

        // Метод заполнения массива с клавиатуры
        public void FillKeyboard()
        {
            Console.WriteLine("Ввод с клавиатуры:");
            Console.WriteLine("Тип данных: " + typeof(T));

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"[{i}] = ");

                if (typeof(T) == typeof(int))
                {
                    array[i] = (T)(object)Convert.ToInt32(Console.ReadLine());
                }
                else if (typeof(T) == typeof(double))
                {
                    array[i] = (T)(object)Convert.ToDouble(Console.ReadLine());
                }
                else if (typeof(T) == typeof(bool))
                {
                    array[i] = (T)(object)Convert.ToBoolean(Console.ReadLine());
                }
                else if (typeof(T) == typeof(string))
                {
                    array[i] = (T)(object)Convert.ToString(Console.ReadLine());
                }

                Console.WriteLine();
            }
        }

        // Метод вывода массива на экран
        public void Print()
        {
            Console.WriteLine("Вывод массива:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
