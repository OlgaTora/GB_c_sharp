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

// void CheckDayOff(int day)
// {
//     if (day < 8 & day > 0)
//         {
//             if (day < 6 & day > 0) Console.WriteLine("нет");
//             else Console.WriteLine("да");
//         }
//     else Console.WriteLine("Порядковый номер дня должен быть от 1 до 7");
//     }

// Console.WriteLine("Введите порядковый номер дня недели");
// int day = int.Parse(Console.ReadLine());

// CheckDayOff(day);