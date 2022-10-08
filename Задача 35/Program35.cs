/*
Задача 37:
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

void zadacha37()
{
    {
        int sise = 8;
        int[] numbers = new int[sise];/* массив создан */
        Console.WriteLine($"{sise} <- размер массива");

        FillArray(numbers);
        PrintArray(numbers);

        int MaxIndex = numbers.Length - 1;
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            Console.WriteLine(numbers[i] + "*" + numbers[MaxIndex - i] + " = " + numbers[i] * numbers[MaxIndex - i]);
        }
        if (numbers.Length % 2 == 1)
        {
            Console.WriteLine(numbers[numbers.Length / 2]);
        }
        Console.WriteLine();
    }

    void FillArray(int[] num) /* массив на заполнение */
    {
        Random vasya = new Random();
        for (int i = 0; i < num.Length; i++) //num.Length -длина массива = size 
        {
            num[i] = vasya.Next(1, 10);
        }
        Console.WriteLine();
    }

    void PrintArray(int[] numb)
    {
        for (int i = 0; i < numb.Length; i++)
        {
            Console.Write(numb[i] + ", ");
        }
        Console.WriteLine();
    }

}
zadacha37();








