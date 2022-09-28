// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
//в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// string GetNumbers(int startNumber)
// {
//     if (startNumber > 1) return $"{startNumber}" + ", " + GetNumbers(startNumber - 1);
//     else return "1";
// }

// try
// {
//     Console.Write("Input N > 0: ");
//     int startNumber = int.Parse(Console.ReadLine());
//     if (startNumber < 0) Console.WriteLine("Error! You have to input natural number!");
//     else Console.WriteLine(GetNumbers(startNumber));
// }
//  catch (Exception ex)
// {
//      Console.WriteLine("Error! You have to input natural number!");
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int GetSum(int startNumber, int endNumber)
// {
//     int sum = 0;
//     if (startNumber == endNumber) sum = startNumber;
//     else
//     {
//         // В задании не указано, какое число больше 
//         if (startNumber < endNumber)
//         {
//             sum = endNumber + GetSum(startNumber, endNumber - 1);
//         }
//         else sum = startNumber + GetSum(startNumber - 1, endNumber);
//     }
//     return sum;
// }

// try
// {
//     Console.Write("Input M > 0: ");
//     int startNumber = int.Parse(Console.ReadLine());
//     Console.Write("Input N > 0: ");
//     int endNumber = int.Parse(Console.ReadLine());
//     if (startNumber < 0 || endNumber < 0) Console.WriteLine("Error! You have to input natural number!");
//     else
//     {
//         int sum = GetSum(startNumber, endNumber);
//         Console.WriteLine($"Sum is: {sum}");
//     }
// }

//  catch (Exception ex)
// {
//      Console.WriteLine("Error! You have to input natural number!");
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Ackermann(int numberM, int numberN)
// {
// if (numberM == 0) return numberN + 1;
// else if (numberM > 0 && numberN == 0) return Ackermann(numberM - 1, 1);
// else return Ackermann(numberM - 1, Ackermann(numberM, numberN - 1));
// }

// try
// {
//     Console.Write("Input M > 0: ");
//     int numberM = int.Parse(Console.ReadLine());
//     Console.Write("Input N > 0: ");
//     int numberN = int.Parse(Console.ReadLine());
//     if (numberM < 0 || numberN < 0) Console.WriteLine("Error! You have to input natural number!");
//     else
//     {
//         int aсkermann = Ackermann(numberM, numberN);
//         Console.WriteLine($"Ackermann function result is: {aсkermann}");
//     }
// }

//  catch (Exception ex)
// {
//      Console.WriteLine("Error! You have to input natural number!");
// }


// Task 63. Все натуральные числа между 1 и N.

// string GetNaturalNumbers(int endNumber)
// {
//     string natNum = "";
//     if (endNumber == 1) natNum = "1";
//     else natNum = GetNaturalNumbers(endNumber - 1) +"," + $"{endNumber}";
//     return natNum;
// }     

// int GetSumNumbers(int endNumber)
// {
//     if(endNumber == 0) return 0;
//     int sum = 0;
//     sum = GetSumNumbers(endNumber - 1) + endNumber;
//     return sum;
// }

// try
// {
//     Console.Write("Input N > 0: ");
//     int endNumber = int.Parse(Console.ReadLine());
//     if (endNumber < 0) Console.WriteLine("Error! You have to input natural number!");
//     else
//     {
//         Console.WriteLine(GetNaturalNumbers(endNumber));
//         int sum = GetSumNumbers(endNumber);
//         Console.WriteLine($"Sum is: {sum}");
//     }
// }
//  catch (Exception ex)
// {
//      Console.WriteLine("Error! You have to input natural number!");
// }

//Task 65. Все натуральные числа между  N и M, их сумма.

// Console.WriteLine("Input N > 0: ");
// int startNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Input M > 0: ");
// int endNumber = int.Parse(Console.ReadLine());

// string GetNaturalNumbers(int startNumber, int endNumber)
// {
//     string natNum = "";
//     if (endNumber == startNumber) natNum = $"{startNumber}";
//     else natNum = GetNaturalNumbers(startNumber, endNumber - 1) + ", " + $"{endNumber}";
//     return natNum;
// }

// Console.WriteLine(GetNaturalNumbers(startNumber, endNumber));

// int GetSumNumbers(int endNumber)
// {
//     if(endNumber == 0) return 0;
//     int sum = 0;
//     sum = GetSumNumbers(endNumber - 1) + endNumber;
//     return sum;
// }
// int sum = GetSumNumbers(endNumber);
// Console.WriteLine(sum);

// Task 67. Считаем сумму цифр в числе, рекурсия.

// Console.WriteLine("Input N: ");
// int number = int.Parse(Console.ReadLine());

// int GetSum(int number)
// {
//     int sum = 0;
//     if (number > 0)
//     {
//         sum = GetSum(number/10) + (number % 10);
//     }
//     return sum;
// }     
// int sum = GetSum(number);
// Console.WriteLine($"Sum is: {sum}");

// Task 69. Возведение в степень рекурсия.

// Console.WriteLine("Input A: ");
// int numberA = int.Parse(Console.ReadLine());
// Console.WriteLine("Input B: ");
// int numberB = int.Parse(Console.ReadLine());

// int GetPow(int numberA, int numberB)
// {
//     if (numberB == 1) return numberA;
//     else return numberA*(GetPow(numberA, numberB - 1));
// }     
// Console.WriteLine($"Pow is: ");
// Console.WriteLine(GetPow(numberA, numberB));
    