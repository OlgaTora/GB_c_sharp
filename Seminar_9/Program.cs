// Task 63. Все натуральные числа между 1 и N.

// Console.WriteLine("Input N > 0: ");
// int endNumber = int.Parse(Console.ReadLine());

// string GetNaturalNumbers(int endNumber)
// {
//     string natNum = "";
//     if (endNumber == 1) natNum = "1";
//     else natNum = GetNaturalNumbers(endNumber - 1) +"," + $"{endNumber}";
//     return natNum;
// }     
// Console.WriteLine(GetNaturalNumbers(endNumber));

// int GetSumNumbers(int endNumber)
// {
//     if(endNumber == 0) return 0;
//     int sum = 0;
//     sum = GetSumNumbers(endNumber - 1) + endNumber;
//     return sum;
// }
// int sum = GetSumNumbers(endNumber);
// Console.WriteLine(sum);

//Task 65. Все натуральные числа между  N и M.

Console.WriteLine("Input N > 0: ");
int startNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Input M > 0: ");
int endNumber = int.Parse(Console.ReadLine());

string GetNaturalNumbers(int startNumber, int endNumber)
{
    string natNum = "";
    if (endNumber == startNumber) natNum = $"{startNumber}";
    else natNum = GetNaturalNumbers(startNumber, endNumber - 1) + ", " + $"{endNumber}";
    return natNum;
}

Console.WriteLine(GetNaturalNumbers(startNumber, endNumber));

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
    