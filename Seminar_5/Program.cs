// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] GetFilledArray(int size, int startValue, int endValue)
// {
//     var my_array = new int [size];
//     // создаем объект, который имеет тип рандом
//     var random = new Random();
//     for (int i = 0; i < my_array.Length; i++)
//     {
//     my_array[i] = random.Next(startValue, endValue + 1);
//     }
//     return my_array;
// }

// int CountPositiveNumbers(int [] my_array)
// {
//     int count = 0;
//     for (int i = 0; i < my_array.Length; i++)
//     {
//         if (my_array[i] % 2 == 0)
//         {
//             count ++;
//         }
//     }
//     return count;
// }
// var my_array = GetFilledArray(12, 100, 1000);
// //  Для примера беру size = 12
// Console.WriteLine($"Random list is: [{string.Join(", ", my_array)}]");
// int count = CountPositiveNumbers(my_array);
// Console.WriteLine($"There are {count} positive numbers in random list");

//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 ; [-4, -6, 89, 6] -> 0

int [] GetFilledArray(int size, int startValue, int endValue)
{
    var my_array = new int [size];
    // создаем объект, который имеет тип рандом
    var random = new Random();
    for (int i = 0; i < my_array.Length; i++)
    {
    my_array[i] = random.Next(startValue, endValue + 1);
    }
    return my_array;
}

int CountPositiveNumbers(int [] my_array)
{
    int count = 0;
    for (int i = 0; i < my_array.Length; i++)
    {
        if (my_array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}
var my_array = GetFilledArray(12, 100, 1000);
//  Для примера беру size = 12
Console.WriteLine($"Random list is: [{string.Join(", ", my_array)}]");
int count = CountPositiveNumbers(my_array);
Console.WriteLine($"There are {count} positive numbers in random list");

//Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3 [6 7 3 6] -> 36 21

// int [] GetFilledArray(int size)
// {
//      var myArray = new int [size];
//      var random = new Random();
//      for (int i = 0; i < myArray.Length; i++)
//      {
//      myArray[i] = random.Next(0, 100);
//      }
//      return myArray;
// }

// int [] GetMultyElements(int [] myArray, int size)
// {
//     var newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = myArray[i] * myArray[myArray.Length - i];
//     }
// return newArray;
// }

// var myArray = GetFilledArray(10);
// int size = myArray.Length / 2;
// var newArray = GetMultyElements(myArray, size);
// Console.WriteLine($"First list is: [{string.Join(", ", myArray)}]");
// Console.WriteLine($"Multiply list is: [{string.Join(", ", newArray)}]");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


// Task 31 Задайте массив  из 12 элементов, заполненный случайными числами от -9 до 9. Найдите сумму + и - чисел

// int [] GetFilledArray(int size, int startValue, int endValue)
// {
//     var my_array = new int [size];
//     // создаем объект, который имеет тип рандом
//     var random = new Random();
//     for (int i = 0; i < my_array.Length; i++)
//     {
//     my_array[i] = random.Next(startValue, endValue + 1);
//     }
//     return my_array;
// }

// var my_array = GetFilledArray(12, -9, 9);

// int GetSumPositive(int [] my_array)
// {
//     var sum = 0;
//     for (int i = 0; i < my_array.Length; i ++)
//     {
//         if (my_array[i] > 0) sum += my_array[i];
//     }
//     return sum;
// }
// var sumPositive = GetSumPositive(my_array);

// int GetSumNegative(int [] my_array)
// {
//     var sum = 0;
//     for (int i = 0; i < my_array.Length; i ++)
//     {
//         if (my_array[i] < 0) sum += my_array[i];
//     }
//     return sum;
// }
// var sumNegative = GetSumNegative(my_array);

// Console.WriteLine(string.Join(", ", my_array));
// Console.WriteLine($"Сумма положительных элементов равна {sumPositive}");
// Console.WriteLine($"Сумма отрицательных элементов равна {sumNegative}");

// Task 32 Замена элементов массива с + на - и наоборот.

// int[] GetArray(int number)
// {
//      int[] my_array = new int[number];
//      for (int i = 0; i < number; i++)
//      {
//          Console.Write("Input list number: ");
//          my_array[i] = int.Parse(Console.ReadLine());
//      }
//      return my_array;
// }

// Console.Write("Input length of list: ");

// int [] ChangeArray (int [] array)
// {
//     var newArray = new int [array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         newArray[i] = array[i] * -1;
//     }
// return newArray;
// }
// try
//  {
//     int number = int.Parse(Console.ReadLine());
//     int[] array = GetArray(number);
//     int[] newArray = ChangeArray(array);
//     Console.WriteLine($"Your list is: [{string.Join(", ", array)}]");
//     Console.WriteLine($"Your new list is: [{string.Join(", ", newArray)}]");
// }
//  catch (Exception ex)
//  {
//      Console.WriteLine("Error! You have to input list of numbers!");
//  }

// Task 33

// int[] GetArray(int quantity)
// {
//      int[] my_array = new int[quantity];
//      for (int i = 0; i < quantity; i++)
//      {
//          Console.Write("Input list number: ");
//          my_array[i] = int.Parse(Console.ReadLine());
//      }
//      return my_array;
// }

// Console.Write("Input length of list: ");

// bool SearchNumber (int [] array)
// {
//     bool flag = false;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//             {
//             return flag = true;
//             break;
//             }
//     return flag;
//     }
// }
// try
//  {
//     Console.WriteLine("Input your number: ");
//     int number = int.Parse(Console.ReadLine());
//     int quantity = int.Parse(Console.ReadLine());
//     int[] array = GetArray(number);
//     if (result = true) Console.WriteLine("YES");
//     else Console.WriteLine("NO");
//  }
//  catch (Exception ex)
//  {
//      Console.WriteLine("Error! You have to input list of numbers!");
//  }

//Task 35 Задайте массив из 123 чисел и найдите количество элементов, значения которых лежат в отрезке от 10 до 99

// int [] GetFilledArray(int size)
// {
//      var my_array = new int [size];
//      var random = new Random();
//      for (int i = 0; i < my_array.Length; i++)
//      {
//      my_array[i] = random.Next(1, 1000);
//      }
//      return my_array;
// }

// int GetQuantityElements(int [] array, int startValue, int endValue)
// {
//     var sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > startValue && array[i] < endValue + 1)
//         sum ++;
//     }
//     return sum;
// }

// var array = GetFilledArray(123);
// Console.WriteLine("Введите стартовое число отрезка: ");
// int startValue = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите конечное число отрезка: ");
// int endValue =  int.Parse(Console.ReadLine());
// int sum = GetQuantityElements(array, startValue, endValue);
// Console.WriteLine(sum);

