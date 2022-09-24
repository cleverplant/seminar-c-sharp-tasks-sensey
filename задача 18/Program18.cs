/*
задача 18. 

Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).

                                       |
                                       |
                                2      |     1
                        ---------------|---------------->               
                                       |
                                3      |     4 
                                       |
                                       |

*/
string N = " ∞ ";
zadacha18();
void zadacha18()
{
    Console.WriteLine("введите номер четверти");
    int num = Convert.ToInt32(Console.ReadLine());
    check(num);

}

void check(int num)
{
    if (num == 1)
    {
        Console.WriteLine(" в 1 четверти Х в диапазоне (0;  + ∞) - Y в диапазоне (0;  + ∞)");
    }
    else if (num == 2)
    {
        Console.WriteLine(" в 2 четверти Х в диапазоне (- ∞;  0) - Y в диапазоне (0;  + ∞)");
    }

    else if (num == 3)
    {
        Console.WriteLine(" в 3 четверти Х в диапазоне (- ∞;  0) - Y в диапазоне (- ∞;  0)");
    }
    else if (num == 4)
    {
        Console.WriteLine(" в 4 четверти Х в диапазоне (0;  + ∞) - Y в диапазоне (0;  + ∞)");
    }
    else
    {
       Console.WriteLine(" ... что-то пошло не так");
    }

}



