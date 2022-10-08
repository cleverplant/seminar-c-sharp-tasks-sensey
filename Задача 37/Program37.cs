/*Задача 35:]() 

Задайте одномерный массив из 10 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

void zadacha35()
{
    {
        int sise = 6;
        int[] numbers = new int[sise];/* массив создан */
        Console.WriteLine($"{sise} <- размер массива");

        FillArray(numbers);
        PrintArray(numbers);
        FindArray(numbers);
    }

    void FillArray(int[] num) /* массив на заполнение */
    {
        Random vasya = new Random();
        for (int i = 0; i < num.Length; i++) //num.Length -длина массива = size 
        {
            num[i] = vasya.Next(-10, 100);
        }
    }

    void PrintArray(int[] numb)
    {
        for (int i = 0; i < numb.Length; i++)
        {
            Console.Write(numb[i] + ", ");
        }
        Console.WriteLine();
    }

    void FindArray(int[] num) /* массив на заполнение */
    {
        int count = 0;

        for (int i = 0; i < num.Length; i++)
            if (num[i] >= 10 && num[i] <= 99)
            {
                count++;
                //Console.WriteLine(count);
            }
        Console.Write(count + " ,");
    }
}
zadacha35();




