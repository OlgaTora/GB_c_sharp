// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());

// Console.WriteLine($"Последняя цифра {number} = {number % 10}");


Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int x = 2;
while(x < number)
{
    Console.WriteLine(x);
    x += 2;
}