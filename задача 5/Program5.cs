/* 
              ФУНКЦИИ
5. Напишите программу вычисления значения
функции возведения числа в квадрат.
4 -> 16
-3 -> 9
-7 -> 49 
*/



int MyFunction(int x = 5)// <= есть обязательные и необязательные параметры 
{
    Console.WriteLine("возвращаю аргумент функции : " + x);
    return x * x;
}    

Console.WriteLine("возвращаю результат работы функции: " + MyFunction());// <= (x = 5)результат с обязательным параметром

Console.Write("введите число для возведения в квадрат: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("результат:" + MyFunction(number)); 


