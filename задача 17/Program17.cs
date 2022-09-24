/*
задача 17. 

Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
в которой находится эта точка.

                                       |
                                       |
                                2      |     1
                        ---------------|---------------->               
                                       |
                                3      |     4 
                                       |
                                       |
*/
//zadacha17();
void zadacha17()
{
Random random = new Random();
int x = random.Next(-10, 11);
int y = random.Next(-10, 11);
Console.WriteLine($"A({x}, {y})");

if (x > 0 && y > 0)
{
    Console.WriteLine("точка лежит в 1 четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("точка лежит в 2 четверти");   
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("точка лежит в 3 четверти");   
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("точка лежит в 4 четверти");   
}
else
{
Console.WriteLine("точка лежит на одной из осей. т.е. на 0 -> x = 0 || y = 0");
}
}


zadacha17_metod_vnutry();
void zadacha17_metod_vnutry()
{
Random random = new Random();
int XX = random.Next(-10, 11);
int YY = random.Next(-10, 11);
Console.WriteLine($"A({XX}, {YY})");
coordinaty(XX, YY); 
}

void coordinaty(int x, int y)
{
    if (x > 0 && y > 0)
{
    Console.WriteLine("точка лежит в 1 четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("точка лежит в 2 четверти");   
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("точка лежит в 3 четверти");   
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("точка лежит в 4 четверти");   
}
else
{
Console.WriteLine("точка лежит на одной из осей. т.е. на 0 -> x = 0 || y = 0");
}
}







