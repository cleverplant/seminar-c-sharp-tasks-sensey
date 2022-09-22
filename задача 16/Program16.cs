/*
задача 16. 
Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

// int Input();
// {
//     Console.Write("введите число для сравнения: ");
//     return Convert.ToInt32(Console.ReadLine());
// }
// int num_1 = Input();
// int num_2 = Input();

zadacha16();
void zadacha16()
{
    Console.Write("введите 1-е число для сравнения: ");
        int number_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("введите 2-е число для сравнения: ");
        int number_2 = Convert.ToInt32(Console.ReadLine());
    //if (number_1 == Math.Pow(number_2, 2) ||  (number_2 == Math.Pow(number_1, 2)
    if (number_1 == number_2 * number_2 || number_2 == number_1 * number_1)
    {
        Console.Write("да ");
    }
    else
    {
        Console.WriteLine("нет");
    }
}


