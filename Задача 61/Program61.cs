/*
Дополнительная задача:
Задача 61:Задайте две матрицы.
Напишите программу, которая будет находить произведение двух матриц.

                   СДЕЛАЛ В ДОМАШКЕ

*/

void z61()
{
Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    Console.WriteLine($"Строк:{rows}, Столбцов:{columns}");


//     FillArray(numbers);
//     PrintArray(numbers);

// void FillArray(int[,] matr)
//     {
//         for (int i = 0; i < matr.GetLength(0); i += 2)
//         {
//             for (int j = 0; j < matr.GetLength(1); j += 2)
//             {
//                 matr[i, j] = new Random().Next(1, 10);// 
//             }
//             //Console.WriteLine();
//         }
//         Console.WriteLine();
//     }

//     void PrintArray(int[,] matr)
//     {
//         for (int i = 0; i < matr.GetLength(0); i++)// rows - строки
//         {
//             for (int j = 0; j < matr.GetLength(1); j++)// columns -столбцы
//             {
//                 Console.Write($"{matr[i, j] + " "}");// 
//             }
//             Console.WriteLine();
//         }
//     }







}
z61();



