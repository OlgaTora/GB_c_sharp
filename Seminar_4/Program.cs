// ToDo 
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵); 2, 4 -> 16
// Для отрицательных считается также как и для положительных чисел.

int GetExponent(int a, int b)
{
    int result = Convert.ToInt32(Math.Pow(a, b));
    return result;
}

try
{
    Console.Write("Input A: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Input B: ");
    int b = int.Parse(Console.ReadLine());

    int exsponent = GetExponent(a, b);
    Console.WriteLine($"Число {a} в натуральной степени {b} = {exsponent}");
}
catch (Exception ex)
{
    Console.WriteLine("Error! You have to input number!");
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12


// int GetSum(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     return sum;
// }

// try
// {
//     Console.Write("Input number: ");
//     int number = Math.Abs(int.Parse(Console.ReadLine()));

//     int sum = GetSum(number);
//     Console.WriteLine($"Сумма цифр в числе = {sum}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error! You have to input number!");
// }

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Элементы вводятся пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]

// Вариант с любым количеством цифр и вводом цифр построчно.

int[] GetArray(int number)
{
     int[] my_array = new int[number];
     for (int i = 0; i < number; i++)
     {
         Console.Write("Input list number: ");
         my_array[i] = int.Parse(Console.ReadLine());
     }
     return my_array;
}

Console.Write("Input length of list: ");

int [] ChangeArray (int [] array
{
    var newArray = new int [];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i] * -1;
    }
return newArray
) 
try
 {
    int number = int.Parse(Console.ReadLine());
    int[] array = GetArray(number);
    int[] newArray = ChangeArray(array);
    Console.WriteLine($"Your list is: [{string.Join(", ", array)}]");
    Console.WriteLine($"Your list is: [{string.Join(", ", array)}]");
}
 catch (Exception ex)
 {
     Console.WriteLine("Error! You have to input list of numbers!");
 }

// Вариант с вводом цифр, как в задании, но без использования метода.

// try
// {
//     Console.Write("Input list: 8 numbers: ");
//     int [] my_array = (Console.ReadLine().Split(", ").Select(e => Convert.ToInt32(e)).ToArray());
//     if (my_array.Length == 8)
//     {
//         Console.WriteLine($"Your list is: [{string.Join(", ", my_array)}]");
//     }
//     else Console.WriteLine("You have to inpup 8 numbers!");
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error! You have to input list of numbers separated by commas!");
// }

// Задачи на самом семинаре.
// Task 24 Напишите программу, которая принимает на вход число А и выдает сумму от 1 до А.

// int GetSum(int number)
// {
//     int sum = 0;
//     if (number > 0)
//     {
//         for (int i = 1; i <= number; i++)
//         {
//             sum = sum + i;
//         }
//     }
//     else
//     {
//         for (int i = 1; i >= number; i--)
//         sum = sum + i;
//     }

//     return sum;
// }

// Console.Write("Input A: ");
// try
// {
//     int a = int.Parse(Console.ReadLine());

//     int sum = GetSum(a);
//     Console.WriteLine(sum);
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error");
// }

// Task 26 На вход целое число и выдает кол-во цифр в числе.

// int QuantityNum (int number)
// {
//     int count = 0;
//     while (number > 0)
//     {
//         number = number / 10;
//         count ++;
//     }
//     return count;
// }

// Console.Write("Input number: ");
// try
// {
//     int num = Math.Abs(int.Parse(Console.ReadLine()));

//     int quantity = QuantityNum(num);
//     Console.WriteLine(quantity);
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error");
// }

// Task 28

// int GetMulty(int number)
// {
//     int multy = 1;
//     if (number > 0)
//     {
//         for (int i = 1; i <= number; i++)
//         {
//             multy = multy * i;
//         }
//     }
//     else
//         multy = 0;

//     return multy;
// }

// Console.Write("Input A: ");
// try
// {
//     int a = int.Parse(Console.ReadLine());

//     int multy = GetMulty(a);
//     Console.WriteLine(multy);
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error");
// }


//Task 30 Заполнить массив из 8 знаков от 0 до 1 в случайном порядке

// int [] array = new int [8];
// for (int i = 0; i < 8; i ++)
// {
//     array [i] = new Random().Next(0, 2);
// }
// int [] result = array;
// Console.WriteLine(string.Join(", ", result));