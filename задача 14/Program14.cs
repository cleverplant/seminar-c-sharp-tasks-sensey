/*
задача 14. 
Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/
zadacha14_logic();
void zadacha14_logic()
{
    Console.Write("введите число для сравнения: ");
    int number_1 = Convert.ToInt32(Console.ReadLine());
    int ostatok_1 = number_1 % 7;
    int ostatok_2 = number_1 % 23;

    if (ostatok_1 == 0 && ostatok_2 == 0)
    {
        Console.Write("да ");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

//zadacha14_matematic();
void zadacha14_matematic()
{
    Console.Write("введите число для сравнения: ");
    int number_1 = Convert.ToInt32(Console.ReadLine());

    int ostatok = number_1 % (7 * 23);
    if (ostatok == 0)
    {
        Console.Write("да ");
    }
    else
    {
        Console.WriteLine("нет");
    }
}