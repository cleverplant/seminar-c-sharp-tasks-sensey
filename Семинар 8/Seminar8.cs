using System;

namespace Project
{
    class Program
    {

        static void Main(string[] args)
        {

            void Zadacha53()
            {
                var random = new Random();
                int rows = random.Next(4, 8);
                int columns = random.Next(4, 8);
                int[,] numbers = new int[rows, columns];
                FillArray(numbers);
                PrintArray(numbers);

                int min_i = 0;
                int max_i = rows - 1;
                for (int j = 0; j < columns; j++)
                {
                    (numbers[min_i, j], numbers[max_i, j]) =
                                            (numbers[max_i, j], numbers[min_i, j]);
                }
                Console.WriteLine();
                PrintArray(numbers);
            }

            void Zadacha55()
            {
                Random random = new Random();
                int rows = random.Next(4, 8);
                int columns = rows;
                int[,] numbers = new int[rows, columns];
                Console.WriteLine($"Строк:{rows}, Столбцов:{columns}");
                FillArray(numbers);
                PrintArray(numbers);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = i; j < columns; j++)
                    {
                        (numbers[i, j], numbers[j, i]) = (numbers[j, i], numbers[i, j]);
                    }
                }
                Console.WriteLine();
                PrintArray(numbers);
            }

            void Zadacha59()
            {
                var random = new Random();
                int rows = random.Next(4, 8);
                int columns = random.Next(4, 8);
                int[,] numbers = new int[rows, columns];
                FillArray(numbers, -100, 100);
                PrintArray(numbers);

                int min = numbers[0, 0];
                int i_min = 0;
                int j_min = 0;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (numbers[i, j] < min)
                        {
                            min = numbers[i, j];
                            i_min = i;
                            j_min = j;
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"N[{i_min + 1}, {j_min + 1}] = {min}");

                int rowsResult = rows - 1;
                int columnsResult = columns - 1;
                int[,] result = new int[rowsResult, columnsResult];
                int bias_i = 0;
                int bias_j = 0;
                for (int i = 0; i < rowsResult; i++)
                {
                    if (i == i_min) bias_i++;
                    bias_j = 0;
                    for (int j = 0; j < columnsResult; j++)
                    {
                        if (j == j_min) bias_j++;
                        result[i, j] = numbers[i + bias_i, j + bias_j];
                    }
                }
                Console.WriteLine();
                PrintArray(result);
                Console.WriteLine();
                for (int i = 0; i < rows; i++)
                {
                    if (i != i_min)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            if (j != j_min)
                                Console.Write(numbers[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
            }

            Zadacha59();


            //Zadacha53();

        }


        #region Fill & Print
        static void FillArray(int[] numbers,
                       int minValue = 0,
                       int maxValue = 9)
        {
            maxValue++;
            int size = numbers.Length;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
            }
        }


        static void PrintArray(int[] numbers)
        {
            int size = numbers.Length;
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + "  ");
            }
            Console.WriteLine();
        }

        static void FillArray(double[] numbers,
            int minValue = 0,
            int maxValue = 9)
        {
            maxValue++;
            int size = numbers.Length;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                double value = random.NextDouble() * 20 - 10;
                numbers[i] = Math.Round(value, 2);
            }
        }

        static void PrintArray(double[] numbers)
        {
            int size = numbers.Length;
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + "  ");
            }
            Console.WriteLine();
        }
        static void FillArray(
            int[,] array,
            int startNumber = 0,
            int finishNumber = 10
        )
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            Random random = new Random();
            finishNumber++;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(startNumber, finishNumber);
                }
            }
        }

        static void FillArray(double[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Math.Round(random.NextDouble() * 10 - 5, 2);
                }
            }
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }

        static void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }
        #endregion


    }
}
