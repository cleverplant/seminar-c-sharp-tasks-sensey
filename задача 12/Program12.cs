/*
задача 12. 
Напишите программу, которая будет принимать на вход два числа 
и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/
zadacha12();
void zadacha12()
{
    Console.Write("введите 1-е число для сравнения: ");
    int number_1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите 2-е число для сравнения: ");
    int number_2 = Convert.ToInt32(Console.ReadLine());
    int ostatok = number_1 % number_2;

    if (ostatok == 0)
    {
        Console.WriteLine("кратно. ");
        Console.WriteLine(ostatok);
    }
    else
    {
        Console.WriteLine("не кратно. остаток:");
        Console.WriteLine(ostatok);
    }
}
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


