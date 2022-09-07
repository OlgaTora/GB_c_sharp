// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.
// 14212 -> нет // 12821 -> да // 23432 -> да

// void Palindrom(int x)
// {
//     if (x > 9999 & x < 100000)
//         {
//             if (x % 10 == x/10000 & (x % 100) / 10 == (x / 1000) % 10)
//             {
//                 Console.WriteLine("да");   
//             }
//         else Console.WriteLine("нет");
//         }
//     else Console.WriteLine("Неправильно введено число");
// };

// Console.WriteLine("Введите пятизначное число");
// int x = Math.Abs(int.Parse(Console.ReadLine()));
// Palindrom(x);

// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и
// //находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84 // A (7,-5, 0); B (1,-1,9) -> 11.53

// double GetDistance(int x1, int x2, int y1, int y2)
// {
//     double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
//     return distance;
// }

// Console.WriteLine("Input x1: ");
// int x1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Input x2: ");
// int x2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Input y1: ");
// int y1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Input y2: ");
// int y2 = int.Parse(Console.ReadLine());

// double result = GetDistance(x1, x2, y1, y2);
// Console.WriteLine(Math.Round(result, 2, MidpointRounding.AwayFromZero));

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27  5 -> 1, 8, 27, 64, 125


// int [] GetCubeNumbers(int number)
// {
//     int [] cubeNumbers = new int [number];
// // fill array
//     for (int i = 1; i <= number; i++)
//         {
//             cubeNumbers[i - 1] = Convert.ToInt32(Math.Pow(i, 3));
//         }
//     return cubeNumbers;
// }

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// int [] result = GetCubeNumbers(number);
// Console.WriteLine(string.Join(", ", result));