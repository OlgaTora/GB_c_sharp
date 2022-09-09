// ToDo 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

// Task 24 Напишите программу, которая принимает на вход число А и выдает сумму от 1 до А

// int GetSum(int number)
// {
//     int sum = 0;
//     if (number > 0)
//     {
//         for (int i = 1; i <= number; i++)
//         {
//             sum = sum + i;
//         }
//     }
//     else
//     {
//         for (int i = 1; i >= number; i--)
//         sum = sum + i;
//     }

//     return sum;
// }

// Console.Write("Input A: ");
// try
// {
//     int a = int.Parse(Console.ReadLine());

//     int sum = GetSum(a);
//     Console.WriteLine(sum);
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error");
// }

// Task 26 На вход целое число и выдает кол-во цифр в числе.

// int QuantityNum (int number)
// {
//     int count = 0;
//     while (number > 0)
//     {
//         number = number / 10;
//         count ++;
//     }
//     return count;
// }

// Console.Write("Input number: ");
// try
// {
//     int num = Math.Abs(int.Parse(Console.ReadLine()));

//     int quantity = QuantityNum(num);
//     Console.WriteLine(quantity);
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error");
// }

// Task 28

// int GetMulty(int number)
// {
//     int multy = 1;
//     if (number > 0)
//     {
//         for (int i = 1; i <= number; i++)
//         {
//             multy = multy * i;
//         }
//     }
//     else
//         multy = 0;

//     return multy;
// }

// Console.Write("Input A: ");
// try
// {
//     int a = int.Parse(Console.ReadLine());

//     int multy = GetMulty(a);
//     Console.WriteLine(multy);
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error");
// }


//Task 30 Заполнить массив из 8 знаков от 0 до 1 в случайном порядке

// int [] array = new int [8];
// for (int i = 0; i < 8; i ++)
// {
//     array [i] = new Random().Next(0, 2);
// }
// int [] result = array;
// Console.WriteLine(string.Join(", ", result));