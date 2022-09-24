// В задачах много общего, вынесу функции создания массива, выбора его размера и печать отдельно

int [,] GetFilledArray(int sizeN, int sizeM)
{
    var myArray = new int [sizeN, sizeM];
    var random = new Random();
    Console.WriteLine("Random array is: ");
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = random.Next(-5, 5);
            Console.Write($"{myArray[i, j]} ");
        }
    Console.WriteLine("");
    }
    return myArray;
}

int GetRandomSize ()
// Задает случайный размер массива.
{
    var random = new Random();
    int size = random.Next(1, 5);
    return size;
}

void PrintMyArray(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
        Console.Write(myArray[i, j]);
        Console.Write(" ");
        }
    Console.WriteLine("");
    }
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
//каждой строки двумерного массива.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] GetSortArray(int [,] myArray)
// {
//     var sortArray = new int[myArray.GetLength(0), myArray.GetLength(1)];
//     for (int i = 0; i < sort.GetLength(0); i++)
//     {
//         max = myArray[i, 0]
//         for (int j = 0; j < sort.GetLength(1); j++)
//         {
//             if (myArray[i, j] < max)
//             {
                

//             }
//         }


//     return sortArray;
// }


// Console.WriteLine("Task 54");

// int sizeN = GetRandomSize();
// int sizeM = GetRandomSize();
// int [,] myArray = GetFilledArray(sizeN, sizeM);

// var sortArray = GetSortArray(myArray);
// PrintMyArray(sortArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
//строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// ответ: 1 строка

// int SearchMinSumRow(int [,] myArray)
// {
//     int minSumRow = 0;
//     int indexMinRow = 0;
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         int sum = 0;
        
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             sum += myArray[i, j];
//             if (sum > minSumRow)
//             {
//                 minSumRow = sum;
//                 indexMinRow = i;
//             }
//         }
//     }  
//     return indexMinRow;
// }

// Console.WriteLine("Task 56");

// int sizeN = GetRandomSize();
// int sizeM = GetRandomSize();
// if (sizeN == sizeM) Console.WriteLine("Error! Array have to be rectangle!");
// else
// {
//     int [,] myArray = GetFilledArray(sizeN, sizeM);

//     int indexMinRow = SearchMinSumRow(myArray);
//     // Строку указаываю как для пользователя, с нумерацией с единицы
//     Console.WriteLine($"The row with minimum sum is {indexMinRow + 1}");
// }
// Console.WriteLine("-------------");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//Task 53
// В двумерном массиве поменять местами первую и последнюю строку

// int [,] GetFilledArray(int sizeN, int sizeM)
// {
//     var myArray = new int [sizeN, sizeM];
//     var random = new Random();
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             myArray[i, j] = random.Next(1, 10);
//             Console.Write($"{myArray[i, j]} ");
//         }
//     Console.WriteLine("");
//     }
//     return myArray;
// }

// int [,] GetReverseArray(int[,] myArray)
// {
//     int tmp = 0;
//     for (int i = 0; i < myArray.GetLength(0); i += myArray.GetLength(0))
//     {
//          tmp = myArray[i, j];
//          myArray[i, j] = myArray[myArray.GetLength(0) - 1, j];
//          myArray[myArray.GetLength(0) - 1, j] = tmp;
//     }
//    return myArray;
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

// var myArray = GetFilledArray(4, 3);
// // Делаю на примере небольшого массива
// var reverseArray = GetReverseArray(myArray);
// Console.WriteLine("-----------------");
// PrintMyArray(reverseArray);

// Task 55 В двумерном массиве поменять местами строки со столбцами.
// Если это невозможно, сообщить.

// int [,] GetTurnArray(int[,] myArray)
// {
//     var turnArray = new int[myArray.GetLength(1), myArray.GetLength(0)];
//     for (int i = 0; i < turnArray.GetLength(0); i ++)
//     {
//         for (int j = 0; j < turnArray.GetLength(1); j++)
//         {
//             turnArray[i, j] = myArray[j, i];
//         }
//     }
//     return turnArray;
// }

// int sizeN = GetRandomSize();
// int sizeM = GetRandomSize();
//Console.WriteLine("Task 55");

// if (sizeN != sizeM)
// {
//     Console.WriteLine("Error! Its not possible for rectangular array!");
//     return;
// }
// else
// {
//     var myArray = GetFilledArray(sizeN, sizeM);

//     int [,] turnArray = GetTurnArray(myArray);
//     Console.WriteLine("-----------------");
//     PrintMyArray(turnArray);
// }


// Task 57
// Сколько раз встречается каждый элемент в массиве

// using System.Linq;

// // Поиск количества значений каждого элемента
// int [] CountQuantityElem(int[,] myArray, int max, int min)
// {
//         // сделать массив массивов
//     var quantityArray = new int[max - min + 1];
//     for (int k = min; k < quantityArray.Length + 1; k++)
//     {
//         for (int i = 0; i < myArray.GetLength(0); i ++)
//         {
//             for (int j = 0; j < myArray.GetLength(1); j++)
//             {
//                 if (myArray[i, j] == k) quantityArray[k] += 1;
//             }
//         }
//     }       
//     return quantityArray;
// }

// int sizeN = GetRandomSize();
// int sizeM = GetRandomSize();
//Console.WriteLine("Task 57");

// var myArray = GetFilledArray(sizeN, sizeM);
// Console.WriteLine("--------------");

// // Мин и макс в двумерном массиве
// int maxValue = myArray.Cast<int>().Max();
// int minValue = myArray.Cast<int>().Min();


// int [] quantityArray = CountQuantityElem(myArray, maxValue, minValue);

// for (int i = 0; i < quantityArray.Length; i ++)
// {
//     if (quantityArray[i] != 0)
//     {
//         Console.WriteLine($"Элемент {i} встречается {quantityArray[i]} раз ");
//     }
// }

// Task 59 Удалить строку и столбец, на пересечении которых наименьший элемент массива

// int [] SearchMinIndex(int[,] myArray)
// {
//     int min = myArray[0, 0];
//     var indexMin = new int [2];
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             if (myArray[i, j] < min)
//             {
//                 min = myArray[i, j];
//                 indexMin[0] = i;
//                 indexMin[1] = j;
//             }
//         }
//     }
//     return indexMin;
// }

// int [,] GetReducedArray(int [,] myArray, int[] indexMin)
// {
//     var reducedArray = new int[myArray.GetLength(0) - 1, myArray.GetLength(1) - 1];
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             if (i != indexMin[0] && j != indexMin[1])
//             {
//                 reducedArray[i, j] = myArray[i, j];
//             }
//         }
//     }
//     return reducedArray;
// }

// int sizeN = GetRandomSize();
// int sizeM = GetRandomSize();
// if (sizeN < 1 | sizeM < 1)
// {
//     Console.WriteLine("This operation is not possible");
// }
// else
// {
//     Console.WriteLine("Task 59");
//     var myArray = GetFilledArray(sizeN, sizeM);
//     Console.WriteLine("--------------");

//     var indexMin = SearchMinIndex(myArray);
//     Console.WriteLine($"The index of min is {string.Join(", ", indexMin)}");
//     int [,] reducedArray = GetReducedArray(myArray, indexMin);
//     PrintMyArray(reducedArray);
// }