// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2 // 1, -7, 567, 89, 223-> 3

int CompareNumbers(int [] myArray)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 0 ) count ++;
    }
    return count;
}

try
{
    Console.Write("Input your numbers: ");
    int [] myArray = (Console.ReadLine().Split(", ").Select(e => Convert.ToInt32(e)).ToArray());
    Console.WriteLine($"You've input: {string.Join(", ", myArray)}");
    int count = CompareNumbers(myArray);
    Console.WriteLine($"There are {count} numbers above 0 in your list");
    
}
catch (Exception ex)
{
    Console.WriteLine("Error! You have to input list of numbers/number separated by commas!");
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Вариант без массива для вводимых координат

// double [] SearchCrossPoint (double b1, double k1, double b2, double k2)
// {
//     double [] crossPoint = new double [2];
//     crossPoint[0] = (b2 - b1) / (k1 - k2);
//     Console.WriteLine(crossPoint[0]);
//     crossPoint[1] = k1 * crossPoint[0] + b1;
//     return crossPoint;
// }

// try
// {
//     Console.Write("Input b1: ");
//     double b1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Input k1: ");
//     double k1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Input b2: ");
//     double b2 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Input k2: ");
//     double k2 = Convert.ToDouble(Console.ReadLine());

//     if (k1 == k2) Console.WriteLine("This lines dont have crossing point");
//     else
//     {
//         double [] point = SearchCrossPoint(b1, k1, b2, k2);
//         // Округление координат до 4 знаков
//         point[0] = Math.Round(point[0], 4, MidpointRounding.AwayFromZero);
//         point[1] = Math.Round(point[0], 4, MidpointRounding.AwayFromZero);
//         Console.WriteLine($"The crossing point is [{string.Join("; ", point)}]");
//     }
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error! You have to input four numbers!");
// }

// Вариант с массивом для вводимых координат

// double [] SearchCrossPoint (double [] coordsA, double [] coordsB)
// {
//     double [] crossPoint = new double [2];
//     crossPoint[0] = (coordsB[0] - coordsA[0]) / (coordsA[1] - coordsB[1]);
//     crossPoint[1] = coordsA[1] * crossPoint[0] + coordsA[0];
//     return crossPoint;
// }

// try
// {
//     Console.Write("Input coordinates x and y for point A: ");
//     double [] coordsA = (Console.ReadLine().Split(", ").Select(e => Convert.ToDouble(e)).ToArray());;
//     Console.Write("Input coordinates x and y for point B: ");
//     double [] coordsB = (Console.ReadLine().Split(", ").Select(e => Convert.ToDouble(e)).ToArray());;
//     if (coordsA[1] == coordsB[1]) Console.WriteLine("This lines dont have crossing point");
//     else
//     {
//         double [] point = SearchCrossPoint(coordsA, coordsB);
//         // Округление коррдинат до 4 знаков
//         point[0] = Math.Round(point[0], 4, MidpointRounding.AwayFromZero);
//         point[1] = Math.Round(point[0], 4, MidpointRounding.AwayFromZero);
//         Console.WriteLine($"The crossing point is {string.Join(", ", point)}");
//     }
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error! You have to input four numbers!");
// }

// Task 39
// Программа, которая перевернет одномерный массив наоборот

// int [] GetFilledArray(int size)
// {
//      var myArray = new int [size];
//      var random = new Random();
//      for (int i = 0; i < myArray.Length; i++)
//      {
//      myArray[i] = random.Next(-100, 100);
//      }
//      return myArray;
// }

// int GetRandomSize ()
// {
//     var random = new Random();
//     int newSize = random.Next(2, 20);
//     // Прописываю рандомный размер массива.
//     return newSize;
// }

// int [] GetReverseArray(int [] myArray)
// {
//     int tmp = 0;
//     for(int i = 0; i <myArray.Length/2; i++)
//     {
//         tmp = myArray[myArray.Length - 1 - i];
//         myArray[myArray.Length - 1 - i] = myArray[i];
//         myArray[i] = tmp;
//     }
//     return myArray;
// }

// int size = GetRandomSize();
// var myArray = GetFilledArray(size);
// Console.WriteLine($"First list is: [{string.Join(", ", myArray)}]");
// int [] result = GetReverseArray(myArray);
// Console.WriteLine($"Reversed list is: [{string.Join(", ", result)}]");

// Task 46 Создать копию вводимого массива, копируя поэлементно.

// int [] CopyArray (int [] myArray)
// {
//     int [] newArray = new int [myArray.Length];

//     for(int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = myArray[i];
//     }
//     return newArray;
// }

// try
// {
//     Console.WriteLine("Input you list with space: ");
//     int [] myArray = (Console.ReadLine().Split(" ").Select(e => Convert.ToInt32(e)).ToArray());
//     Console.WriteLine($"Your list is: {string.Join(" ", myArray)}");

//     var result = CopyArray(myArray);
//     Console.WriteLine($"Copied list is: {string.Join(" ", result)}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error! You have to input list of numbers with space!");
// }


// Task 44 Фибоначи без рекурсии. Вовод всех чисел до N.
//Надо заполнить массив 0 и 1 

// int [] Fib (int number)
// {
//     int [] myArray = new int [number];
//     myArray[0] = 0;
//     if (number == 1) return myArray;
//     else
//     {
//         myArray[1] = 1;
        
//         for(int i = 2; i < number; i++)
//             {
//             myArray[i] = myArray[i - 1] + myArray [i -2 ];
//             }
//     }
//     return myArray;
// }

// try
// {
//     Console.Write("Input number of Fibonacci: ");
//     int number = int.Parse(Console.ReadLine());

//     var myArray = Fib(number);
//     Console.WriteLine($"Fibonacci list is: {string.Join(" ", myArray)}");
// }

// catch (Exception ex)
// {
//     Console.WriteLine("Error! You have to input one number above zero!");
// }

// Task 40 Три числа, может ли существовать треугольник через true false

// bool Triangle(int a, int b, int c)
// {
//     if (a < (b + c) && b < (a + c) && c < (a + b)) return true;
//     else return false;
// }
// try
// {
//     Console.WriteLine("Input A: ");
//     int a = int.Parse(Console.ReadLine());
//     Console.WriteLine("Input B: ");
//     int b = int.Parse(Console.ReadLine());
//     Console.WriteLine("Input C: ");
//     int c = int.Parse(Console.ReadLine());
//     Console.WriteLine(Triangle(a, b, c));
// }
//  catch (Exception ex)
//  {
//      Console.WriteLine("Error! You have to input numbers!");
//  }


// Task 41 Перевод из десятичного в двоичное

// string GetBinary(int number)
// {
//     string result = String.Empty;
//     while (number != 0)
//     {
//         result += Convert.ToString(number % 2);
//         number = number / 2;
//     }
//     return result;
// }
// void PrintString(string result)
// {
//     for(int i = 0; i < result.Length; i++)
//     {
//         Console.Write(result[result.Length - 1 - i]);
//     }
// }

// Console.WriteLine("Input number: ");
// int number = int.Parse(Console.ReadLine());
// string result = GetBinary(number);
// PrintString(result);

// еще вариант
//// result = ReverseString(result)
