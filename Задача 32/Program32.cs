/*
Задача 32:
Напишите программу замены элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

void zadacha32()
{
    {
        int sise = 12;
        int[] numbers = new int[sise];/* массив создан */
        Console.WriteLine($"{sise} <- такой размер массива сейчас");

        FillArray(numbers);
        PrintArray(numbers);
        ChngeValue(numbers);
        PrintArray(numbers);
    }

    void FillArray(int[] num) /* массив на заполнение */
    {
        Random vasya = new Random();
        for (int i = 0; i < num.Length; i++) //num.Length -длина массива = size 
        {
            num[i] = vasya.Next(-9, 10);
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

    void ChngeValue(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = numbers[i] * (-1);// numbers[i] *= -1;
        }

    }

}
zadacha32();


