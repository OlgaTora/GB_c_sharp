// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2 // 1, -7, 567, 89, 223-> 3

// int CompareNumbers(int [] myArray)
// {
//     int count = 0;
//     for (int i = 0; i < myArray.Length; i++)
//     {
//         if (myArray[i] > 0 ) count ++;
//     }
//     return count;
// }

// try
// {
//     Console.Write("Input your numbers: ");
//     int [] myArray = (Console.ReadLine().Split(", ").Select(e => Convert.ToInt32(e)).ToArray());
//     Console.WriteLine($"You've input: {string.Join(", ", myArray)}");
//     int count = CompareNumbers(myArray);
//     Console.WriteLine($"There are {count} numbers above 0 in your list");
    
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error! You have to input list of numbers/number separated by commas!");
// }


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

