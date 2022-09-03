// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5 782 -> 8 918 -> 1

// void SecondDigit(int x)
// {
//     if (Math.Abs(x) > 99 & Math.Abs(x) < 1000) Console.WriteLine((Math.Abs(x) / 10) % 10);
//     else Console.WriteLine("Неправильно введено число");
// }
// Console.WriteLine("Введите трехзначное число");
// int x = int.Parse(Console.ReadLine());

// SecondDigit(x);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или
//сообщает, что третьей цифры нет.
// 645 -> 5  78 -> третьей цифры нет 32679 -> 6

// void ThirdDigit(int x)
// {
//     if (x > 99)
//     {
//         while (x / 1000 > 0)
//         {
//             x = x / 10;
//         }
//          x = x % 10;
//         Console.WriteLine(x);
//     }
//     else Console.WriteLine("третьей цифры нет");  
// }

// Console.WriteLine("Введите число");
// int x = Math.Abs(int.Parse(Console.ReadLine()));

// ThirdDigit(x);

// Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 7 -> да 1 -> нет

// 

// *любое число с консоли вывести без второй цифры на экран

void DelSecondDigit(int x)
{
    int count = 1; //для счета десятков
    int x1 = x;
    if (Math.Abs(x) > 9) //если число меньше 2 знаков
    {
        if  (Math.Abs(x) < 100) Console.WriteLine($"{Math.Abs(x /10)}"); //в числе всего 2 знака
        else
        {
            while (Math.Abs(x1) / 10 > 0)
        {
            x1 = x1 / 10;
            count *= 10;
        }
        Console.WriteLine($"{x1}{Math.Abs(x % (count/10))}");
        }
        }
    else Console.WriteLine($"В данном числе {x} всего одна цифра. Задача не выполнима");  
}

Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
DelSecondDigit(x);