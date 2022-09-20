// Task 47 Задайте двумерный массив случайными double числами.

double[,] GetFilledTwoDemArray(int sizeN, int sizeM, double startValue, double endValue)
{
    var myArray = new double [sizeN, sizeM];
    var random = new Random();
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = Math.Round(random.NextDouble() * (endValue + 1 - startValue)
            + startValue, 2, MidpointRounding.AwayFromZero);
            Console.Write(myArray[i, j]);
            Console.Write("  ");
        }
    Console.WriteLine("");
    }
    return myArray;
}

int sizeN = 0;
int sizeM = 0;

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
   
// Диапазон выбран для примера
GetFilledTwoDemArray(sizeN, sizeM, -100, 100);


// Task 50 Программа принимает позицию элемента и возвращает его значение или указание, что нет
// Элемент - целое число

// int [,] GetFilledTwoDemArray(int sizeN, int sizeM)
// {
//     var myArray = new int [sizeN, sizeM];
//     var random = new Random();
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             myArray[i, j] = random.Next(1, 100);
//             Console.Write($"{myArray[i, j]} ");
//         }
//     Console.WriteLine("");
//     }
//     return myArray;
// }

// void SearchElementArray(int[,] myArray, int [] point)
// {
//     if (point[0] <= myArray.GetLength(0) &&
//         point[1] <= myArray.GetLength(1))
//         {
//             int result = myArray[point[0], point[1]];
//             Console.WriteLine($"Your element is: {result}");
//         }    
//     else Console.WriteLine("Your element is out of range!");
// }

// try
// {
//     Console.Write("Input number of row and column of element: ");
//     int [] point = (Console.ReadLine().Split(", ").Select(e => Convert.ToInt32(e)).ToArray());;
//     var myArray = GetFilledTwoDemArray(5, 5);
//     // Введем размер для примера

//     SearchElementArray(myArray, point);    
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error! You've to input number of row and column separated by commas < 5!");
//     // О том, что ввести надо числа меньше заданного массива
// }


// Task 52 Найти среднее арифметическое  в каждом столбце.
// Элементы - целые числа
// Для разнообразия размер массива тоже рандомный

// int [,] GetFilledTwoDemArray(int sizeN, int sizeM)
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

// int GetRandomSize ()
// // Задает случайный размер массива.
// {
//     var random = new Random();
//     int size = random.Next(1, 6);
//     // Прописываю ограниченный размер массива.
//     return size;
// }

// double [] GetMean(int [,] myArray)
// {
//     double [] mean = new double [myArray.GetLength(1)];
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < myArray.GetLength(0); i++)
//         {
//             sum += myArray[i, j];
//         }
//         mean[j] = sum / myArray.GetLength(1);
//         mean[j] = Math.Round(mean[j], 4, MidpointRounding.AwayFromZero);
//         // Округление до 4 знаков после запятой.
//     }
//     return mean;
// }

// int sizeN = GetRandomSize();
// int sizeM = GetRandomSize();
// var myArray = GetFilledTwoDemArray(sizeN, sizeN);

// double [] result = GetMean(myArray);
// Console.Write($"Means in random array columns are: [{string.Join("; ", result)}]");;

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

// int sizeN = 0;
// int sizeM = 0;

// void GetFilledTwoDemArray(int sizeN, int sizeM)
// {
//     var myArray = new int [sizeN, sizeM];
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             myArray[i, j] = i + j;
//             Console.Write(myArray[i, j]);
//             Console.Write(" ");
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

// GetFilledTwoDemArray(sizeN, sizeM);

// // Task 50 Заменить числа в четных индексах на их квадраты

// int sizeN = 0;
// int sizeM = 0;

// int [,] GetFilledTwoDemArray(int sizeN, int sizeM)
// {
//     var myArray = new int [sizeN, sizeM];
//     var random = new Random();
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             myArray[i, j] = random.Next(1, 10);
//             Console.Write(myArray[i, j]);
//             Console.Write(" ");
//         }
//     Console.WriteLine("");
//     }
//     return myArray;
// }

// void PrintSquaredMyArray(int[,] myArray)
// {
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//         if (i % 2 == 0 && j % 2 == 0)
//         {
//             myArray[i, j] *= myArray[i, j];
//         }
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

// Console.WriteLine("Random array: ");
// int[,] myArray = GetFilledTwoDemArray(sizeN, sizeM);
// Console.WriteLine("New squared array: ");
// PrintSquaredMyArray(myArray);


// Task 50 Посчитать сумму элементов по диагонали

// int sizeN = 0;
// int sizeM = 0;

// int [,] GetFilledTwoDemArray(int sizeN, int sizeM)
// {
//     var myArray = new int [sizeN, sizeM];
//     var random = new Random();
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             myArray[i, j] = random.Next(1, 10);
//             Console.Write(myArray[i, j]);
//             Console.Write(" ");
//         }
//     Console.WriteLine("");
//     }
//     return myArray;
// }

// int GetSumDiagonal(int[,] myArray)
// {
//     int sum = 0;
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//         if (i == j) sum += myArray[i, j];
//         }
//     }
//     return sum;
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

// Console.WriteLine("Random array: ");
// int[,] myArray = GetFilledTwoDemArray(sizeN, sizeM);
// int sum = GetSumDiagonal(myArray);
// Console.WriteLine($"The sum of diagonal elemens is: {sum}");