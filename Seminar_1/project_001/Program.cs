// квадрат числа
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = number*number;
Console.WriteLine($"Квадрат числа {number} = {result}");

//через библиотеку
int result_2 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} = {result_2}");