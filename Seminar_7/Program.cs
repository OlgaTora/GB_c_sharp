﻿// // Task 47 Задайте двумерный массив случайными double числами.\
// ДОДЕЛАТЬ TRY PARSE! ВСЕ РАБОТАЕТ
// double[,] GetFilledTwoDemArray(int sizeN, int sizeM, double startValue, double endValue)
// {
//     var myArray = new double [sizeN, sizeM];
//     var random = new Random();
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             myArray[i, j] = Math.Round(random.NextDouble() * (endValue + 1 - startValue)
//             + startValue, 2, MidpointRounding.AwayFromZero);
//             Console.Write(myArray[i, j]);
//             Console.Write(" ");
//         }
//     Console.WriteLine("");
//     }
//     return myArray;
// }

// Console.Write("Input nimber of rows: ");
// int sizeN = int.Parse(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int sizeM = int.Parse(Console.ReadLine());
    
// // Диапазон выбран для примера
// GetFilledTwoDemArray(sizeN, sizeM, -100, 100);


// Task 50 Программа принимает позицию элемента и возвращает его значение иkи указание, что нет
// Элемент - целое число

// int[,] GetFilledTwoDemArray(int sizeN, int sizeM, int startValue, int endValue)
// {
//     var myArray = new int [sizeN, sizeM];
//     var random = new Random();
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             myArray[i, j] = random.Next(startValue, endValue + 1);
//         }
//     }
//     return myArray;
// }

// int SearchElementArray(int[,] myArray, int [] point)
// {
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//             {
//                 if (myArray[i, j] == point[]) return myArray[i, j];
//             }
//         }
//         return 0;   
//     }
// }

// Console.Write("Input number of row and column of element: ");
// int [] point = Console.ReadLine().ToArray;
// myArray = GetFilledTwoDemArray(2, 3, -10, 10);
// int result = SearchElementArray(myArray, point);

// Task 52 Найти среднее арифметическое  в каждом столбце
// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//         if(image[i,j] == 0) Console.Write($" ");
//         else Console.Write($"+");
//         }
//  Console.WriteLine();
//  }
// }

// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0) 
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }

// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);

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


// Task 46 Заполнить массив случайными целыми числами

// int sizeN = 0;
// int sizeM = 0;
// int[,] GetFilledTwoDemArray(int sizeN, int sizeM, int startValue, int endValue)
// {
//     var myArray = new int [sizeN, sizeM];
//     var random = new Random();
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             myArray[i, j] = random.Next(startValue, endValue + 1);
//         }
//     }
//     return myArray;
// }

// void PrintMyArray(int[,] myArray)
// {
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//         Console.Write(myArray[i, j]);
//         Console.Write(" ");
//         }
//     Console.WriteLine("");
//     }
// }

// Console.Write("Input nimber of rows: ");
// bool parseNIsOk = int.TryParse(Console.ReadLine(), out int n);
// if (!parseNIsOk)
// {
//     Console.WriteLine("Error! You have to input number of rows and columns!");
//     return;
// }
// else sizeN = n;

// Console.Write("Input number of columns: ");
// bool parseMIsOk = int.TryParse(Console.ReadLine(), out int m);
// if (!parseMIsOk)
// {
//     Console.WriteLine("Error! You have to input number of rows and columns!");
//     return;
// }
// else sizeM = m;

// int[,] myArray = GetFilledTwoDemArray(sizeN, sizeM, -100, 100);
//     // Диапазон выбран для примера
// PrintMyArray(myArray);


// Task 48 Заполнить массив числами по формуле: в каждой ячейке сумма ее координат

int sizeN = 0;
int sizeM = 0;

void GetFilledTwoDemArray(int sizeN, int sizeM)
{
    var myArray = new int [sizeN, sizeM];
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = i + j;
            Console.Write(myArray[i, j]);
            Console.Write(" ");
        }
    Console.WriteLine("");  
    }
}

Console.Write("Input nimber of rows: ");
bool parseNIsOk = int.TryParse(Console.ReadLine(), out int n);
if (!parseNIsOk)
{
    Console.WriteLine("Error! You have to input number of rows and columns!");
    return;
}
else sizeN = n;

Console.Write("Input number of columns: ");
bool parseMIsOk = int.TryParse(Console.ReadLine(), out int m);
if (!parseMIsOk)
{
    Console.WriteLine("Error! You have to input number of rows and columns!");
    return;
}
else sizeM = m;

GetFilledTwoDemArray(sizeN, sizeM);

