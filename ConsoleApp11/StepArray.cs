using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    interface IStepArray : IBaseArray
    {
        void ReverseIndex();
        void MidleOne();
    }

    sealed class StepArray : IStepArray
    {
        private int[][] array;

        public int[][] Array { get => array; set => array = value; }

        public StepArray(int[] columns, bool fillKeyboard = false)
        {
            array = new int[columns.Length][];

            for (int i = 0; i < columns.Length; i++)
            {
                array[i] = new int[columns[i]];
            }

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
            for (int x = 0; x < array.Length; x++)
            {
                for (int y = 0; y < array[x].Length; y++)
                {
                    array[x][y] = random.Next(0, 10);
                }
            }
        }

        // Метод заполнения массива с клавиатуры
        public void FillKeyboard()
        {
            Console.WriteLine("Ввод с клавиатуры:");

            for (int x = 0; x < array.Length; x++)
            {
                for (int y = 0; y < array[x].Length; y++)
                {
                    Console.Write($"[{x}][{y}] = ");
                    array[x][y] = int.Parse(Console.ReadLine());
                }
            }

        }

        // Метод вывода массива на экран
        public void Print()
        {
            Console.WriteLine("Вывод массива:");

            for (int x = 0; x < array.Length; x++)
            {
                for (int y = 0; y < array[x].Length; y++)
                {
                    Console.Write(array[x][y] + " ");
                }
                Console.WriteLine(" ");
            }
        }

        public void Middle()
        {
            Console.WriteLine("Среднее значение всего массива");
            int r = 0;
            int q = 0;
            for (int x = 0; x < array.Length; x++)
            {
                for (int y = 0; y < array[x].Length; y++)
                {
                    r += array[x][y];
                    q++;
                }
            }
            Console.WriteLine(r / q);
        }

        public void MidleOne()
        {
            int r = 0;
            int q = 0;
            for (int x = 0; x < array.Length; x++)
            {
                for (int y = 0; y < array[x].Length; y++)
                {
                    r += array[x][y];
                    q++;
                }
                Console.WriteLine("Среднее значение ", x, "массива");
                Console.WriteLine(r / q);
                q = 0;
                r = 0;
            }
        }

        public void ReverseIndex()
        {
            Console.WriteLine("Изменяем массив");
            for (int d = 0; d != array.Length; d++)
            {
                for (int f = 0; f != array[d].Length; f++)
                {
                    if (array[d][f] % 2 == 0)
                    {
                        array[d][f] = d * f;
                    }
                }
            }
            Console.WriteLine("Исправленный массив");
            for (int z = 0; z != array.Length; z++)
            {
                for (int c = 0; c != array[z].Length; c++)
                {
                    Console.Write(array[z][c]);
                }
                Console.WriteLine("");
            }

        }
       
    }


}

