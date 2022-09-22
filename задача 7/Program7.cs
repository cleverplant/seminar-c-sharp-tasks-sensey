/* 
7. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2" 
*/
//Console.WriteLine("результат:" + MyFunction(num_1)); 

Console.Write("введите число: ");
int num_1 = Convert.ToInt32(Console.ReadLine()); // <= вводим 5

int num_2 = num_1 * -1; // <= (5 * -1 == -5) теперь у нас есть интервал от 5(num_1) до -5(num_2)
    while (num_2 <= num_1) // <= 
{
    Console.WriteLine("результат: " + num_2); 
    num_2 = num_2 + 1;
}
Console.WriteLine("результат num_1 => " + num_1 ); 


Console.WriteLine("==КРАСИВОЕ РЕШЕНИЕ |модуль часла| =====");
// => модуль числа - это абсолютное значение числа |-5| = 5
Console.Write("введите число: ");
int nmb_1 = Convert.ToInt32(Console.ReadLine()); // <= вводим 5
nmb_1 = Math.Abs(nmb_1);
int nmb_2 = - nmb_1 ; // <= (5 * -1 == -5) теперь (* -1) необязательно
    while (nmb_2 <= nmb_1) // <= 
{
    Console.WriteLine("результат: " + nmb_2); 
    nmb_2 = nmb_2 + 1;
}
Console.WriteLine("результат nmb_1 => " + nmb_1 ); 



