// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.
// 14212 -> нет // 12821 -> да // 23432 -> да

string CheckPalindrome(int x)
{
    if (x > 9999 & x < 100000)
        {
            if (x % 10 == x/10000 & (x % 100) / 10 == (x / 1000) % 10) return "да";   
            return "нет";
        }
    return "Неправильно введено число";
}

Console.WriteLine("Введите пятизначное число: ");
int x = int.Parse(Console.ReadLine());

string result = CheckPalindrome(x);
Console.WriteLine(result);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84 // A (7,-5, 0); B (1,-1,9) -> 11.53

// double GetDistance3D(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
//     return distance;
// }

// // Хотелось сделать через списки, но получилось только через char, а там не использовать отриц числа.
// Console.WriteLine("Input x1: ");
// int x1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Input x2: ");
// int x2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Input y1: ");
// int y1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Input y2: ");
// int y2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Input z1: ");
// int z1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Input z2: ");
// int z2 = int.Parse(Console.ReadLine());

// double result = GetDistance3D(x1, x2, y1, y2, z1, z2);
// Console.WriteLine(Math.Round(result, 2, MidpointRounding.AwayFromZero));

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27  5 -> 1, 8, 27, 64, 125

// int [] GetCubeNumbers(int number)
// {
//     int [] cubeNumbers = new int [number];
//     // Fill array.
//     for (int i = 1; i <= number; i++)
//         {
//             cubeNumbers[i - 1] = Convert.ToInt32(Math.Pow(i, 3));
//         }
//     return cubeNumbers;
// }

// Console.WriteLine("Введите целое положительное число: ");
// int number = int.Parse(Console.ReadLine());
// // в случае неверного ввода числа
// if (number < 1) Console.WriteLine ($"Введенное число {number} отрицательное или ноль");
// else
// {
// int [] result = GetCubeNumbers(number);
// Console.WriteLine(string.Join(", ", result));
// }