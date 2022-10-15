/*
Задача 63:Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

void cycle()
{



    
    FillArray(numbers);
    PrintArray(numbers);

void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i += 2)
        {
            for (int j = 0; j < matr.GetLength(1); j += 2)
            {
                matr[i, j] = new Random().Next(1, 10);// 
            }
            //Console.WriteLine();
        }
        Console.WriteLine();
    }

    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)// rows - строки
        {
            for (int j = 0; j < matr.GetLength(1); j++)// columns -столбцы
            {
                Console.Write($"{matr[i, j] + " "}");// 
            }
            Console.WriteLine();
        }
    }




}
cycle();


void recursya()
{




}
recursya();
