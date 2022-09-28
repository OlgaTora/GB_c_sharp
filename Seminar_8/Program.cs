// В задачах много общего, вынесу функции создания массива, выбора его размера и печать отдельно

using System.Linq;

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

int GetRandomValue()
// Задает случайный размер массива.
{
    var random = new Random();
    int size = random.Next(1, 10);
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
//     int tmp = myArray[0, 0];

//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1) - 1; j++)
//         {   
//             for (int k = 0; k < myArray.GetLength(1) -1; k++)
//             {   
//                 if (myArray[i, k] < myArray[i, k + 1])
//                 {
//                     tmp = myArray[i, k];
//                     myArray[i, k] = myArray[i, k + 1];
//                     myArray[i, k + 1] = tmp;
//                 } 
//             }
//         }
//     }
//     return myArray;
// }

// Console.WriteLine("Task 54");

// int sizeN = GetRandomValue();
// int sizeM = GetRandomValue();
// int [,] myArray = GetFilledArray(sizeN, sizeM);
// Console.WriteLine("Sorted array is: ");

// var sortArray = GetSortArray(myArray);
// PrintMyArray(sortArray);
// Console.WriteLine("-------------");

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
//     int tmpSum = 0;
    
//     for (int i = 0; i < myArray.GetLength(1); i++)
//         {
//             minSumRow += myArray[0, i];
//         }
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             tmpSum += myArray[i, j];
//         }
//         if (tmpSum < minSumRow)
//         {
//             minSumRow = tmpSum;
//             indexMinRow = i;
//         }
//         tmpSum = 0;
//     }
//     return indexMinRow;
// }

// Console.WriteLine("Task 56");

// int sizeN = GetRandomValue();
// int sizeM = GetRandomValue();
// if (sizeN == sizeM) Console.WriteLine("Error! Array have to be rectangle!");
// else
// {
//     int [,] myArray = GetFilledArray(sizeN, sizeM);

//     int indexMinRow = SearchMinSumRow(myArray);
//     // На вывод номер по порядку.
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

// Console.WriteLine("Task 58");
// // Работает на квадратных матрицах, можно сделать и для прямоугольных
// // Удобнее проверять на них)

// int size = 2;

// int [,] MultyplyMatrix (int [,] matrix1, int [,] matrix2)
// {
//     var multy = new int [matrix1.GetLength(0), matrix1.GetLength(1)];
   
//     for(int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix1.GetLength(0); j++)
//         {
//             for (int k =0; k <matrix1.GetLength(0); k++)
//             {
//                 multy[i, j] += matrix1[i, k] * matrix2[k, j];
//             }
//         }
//     }
//     return multy;
// }

// var matrix1 = GetFilledArray(size, size);
// var matrix2 = GetFilledArray(size, size);
// Console.WriteLine("Multy is: ");
// var multy = MultyplyMatrix(matrix1, matrix2);
// PrintMyArray(multy);

// Console.WriteLine("-------------");

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Поиск элемента по массиву.
// bool SearchElement(int [,,] myArray, int random)
// {
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < myArray.GetLength(2); k++)
//             {
//                 if (myArray[i, j, k] == random) return true;
//             }
//         }
//     }
//     return false;
// }

// int [,,] GetFillThreeArray(int sizeN, int sizeM, int sizeK)
// {
//     var myArray = new int [sizeN, sizeM, sizeK];
        
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < myArray.GetLength(2); k++)
//             {
//                 bool flag = false;
//                 while(flag != true)
//                 {
//                     flag = false;
//                     int random = new Random().Next(0, 20);
//                     if (SearchElement(myArray, random)) continue;
//                     else
//                     {
//                         myArray[i, j, k] = random;
//                         Console.WriteLine($"{myArray[i, j, k]} ({i}, {j}, {k}) ");
//                         flag = true;
//                     }
//                     Console.WriteLine("");            
//                 }
//             }
//         }
//     }
//     return myArray;
// }

// int sizeN = 2;
// int sizeM = 2;
// int sizeK = 2;
// Console.WriteLine("Task 60");

// Console.WriteLine("Random three dimensional array is: ");
// var myArray = GetFillThreeArray(sizeN, sizeM, sizeK);
// Console.WriteLine("-------------");

//Задача 61. Вывести треугольник Паскаля.

// Console.WriteLine("Task 61");

// void PrintPascal(int[,] myArray)
// {
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             if (myArray[i, j] != 0)
//             {
//             Console.Write(myArray[i, j]);
//             Console.Write(" ");
//             }
//         }
//     Console.WriteLine("");
//     }
// }

// int [,] GetPascalTriangle(int row)
// {
//     int column = row;
//     var pascalTriangle = new int[row, column];

//     for (int i = 0; i < row; i++)
//     {
//         pascalTriangle[i, 0] = 1;
//         pascalTriangle[i, i] = 1;
//     }

//     for (int i = 2; i < row; i ++)
//     {
//         for (int j = 1; j <= i; j++)
//         {
//             pascalTriangle[i, j]  = pascalTriangle[i - 1, j - 1] + pascalTriangle[i - 1, j];
//         }
//     }
//     return pascalTriangle;

// }
// Console.WriteLine("Inpit number of row for Pascal Triangle");
// int rowTriangle = int.Parse(Console.ReadLine());

// int [,] pascalTriangle = GetPascalTriangle(rowTriangle);
// Console.WriteLine("-------------");
// PrintPascal(pascalTriangle);

// Console.WriteLine("-------------");

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Console.WriteLine("Task 62");
// // Для массива случайной размерности (для собственного интереса)
// int startPoint = 0;
// int [,] GetSpiralArray(int size, int startValue, int startPoint)
// {
//     var spiralArray = new int[size, size];
//     spiralArray[startPoint, startPoint] = startValue;
//     int x = spiralArray.GetLength(0);
//     int y = spiralArray.GetLength(1);
//     for (int k = 0; k < size / 2; k++)
//     // Цикл для заполнения квадратов массива.
//     {
//         for (int i = startPoint; i < x - startPoint; i++)
//         { 
//             for (int j = startPoint; j < y - startPoint; j++)
//             {
//                 if (i == startPoint) spiralArray[i, j] = startValue ++;
//                 else if (j == y - startPoint - 1) spiralArray[i, j] = startValue ++;
//             }
//         }
//         for (int i = x - startPoint - 1; i > startPoint; i--)
//         { 
//             for (int j = y - startPoint - 2; j >=  startPoint; j--)
//             {
//                 if (i == x - startPoint - 1) spiralArray[i, j] = startValue ++;
//                 else if (j == startPoint) spiralArray[i, j] = startValue ++;
//             }
//         }
//         size = size * size - 3;
//         startPoint ++;
//     }
//     return spiralArray;
// }

// int size = GetRandomValue();
// int startValue = GetRandomValue();
// Console.WriteLine($"Start value is {startValue}");

// var spiralArray = GetSpiralArray(size, startValue, startPoint);
// PrintMyArray(spiralArray);
// Console.WriteLine("-------------");

//Task 53
// В двумерном массиве поменять местами первую и последнюю строку

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

// Console.WriteLine("Task 53");

// var myArray = GetFilledArray(4, 3);
// // Делаю на примере небольшого массива
// var reverseArray = GetReverseArray(myArray);
// Console.WriteLine("-----------------");
// PrintMyArray(reverseArray);
// Console.WriteLine("-------------");

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

// int sizeN = GetRandomValue();
// int sizeM = GetRandomValue();
// Console.WriteLine("Task 55");

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
// Console.WriteLine("-------------");

// Task 57
// Сколько раз встречается каждый элемент в массиве

// Поиск количества значений каждого элемента
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

// int sizeN = GetRandomValue();
// int sizeM = GetRandomValue();
// Console.WriteLine("Task 57");

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
// Console.WriteLine("-------------");

// Task 59 Удалить строку и столбец, на пересечении которых наименьший элемент массива

// int [,] SearchMinIndex(int[,] myArray)
// {
//     int min = myArray[0, 0];
//     var indexMin = new int [1, 2]; //размер массива для координат
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             if (myArray[i, j] < min)
//             {
//                 min = myArray[i, j];
//                 indexMin[0, 0] = i;
//                 indexMin[0, 1] = j;
//             }
//         }
//     }
//     return indexMin;
// }

// int [,] GetReducedArray(int [,] myArray, int[,] indexMin)
// {
//     var reducedArray = new int[myArray.GetLength(0) - 1, myArray.GetLength(1) - 1];
//     int m = 0; // счетчик для строк нового массива
//     int k = 0; // счетчик для столбцов нового массива

//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             if (indexMin[0, 0] != i && indexMin[0, 1] != j)
//             {
//                 reducedArray[m, k] = myArray[i, j];
//                 k++;
//             }            
//         }
//         // можно сделать через доп циклы, как вариант
//         k = 0;
//         if (indexMin[0, 0] != i) m ++;
//     }
//     return reducedArray;
// }
// int sizeN = GetRandomValue();
// int sizeM = GetRandomValue();
// Console.WriteLine("Task 59");
// if (sizeN < 2 | sizeM < 2)
// {
//     Console.WriteLine("This operation is not possible");
// }
// else
// {   
//     var myArray = GetFilledArray(sizeN, sizeM);
//     Console.WriteLine("--------------");

//     var indexMin = SearchMinIndex(myArray);
//     Console.WriteLine($"The index of min is {indexMin[0, 0]}, {indexMin[0, 1]}");
//     Console.WriteLine("--------------");

//     int [,] reducedArray = GetReducedArray(myArray, indexMin);
//     PrintMyArray(reducedArray);
// }
// Console.WriteLine("-------------");
