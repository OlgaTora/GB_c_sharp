//программа, которая по номеру четверти указывает диапазон возможных координат в этой
//четверти (х и у).

// string GetPointArea(int area)
// {
// if (area == 1) return "x>0, y>0";
// if (area == 2) return "x<0, y>0";
// if (area == 3) return "x<0, y<0";
// if (area == 4) return "x>0, y<0";
// return "Такой четверти нет";
// }

// Console.WriteLine("Input area: ");
// int area = Convert.ToInt32(Console.ReadLine());

// string result = GetPointArea(area);
// Console.WriteLine(result);

//ПРОграмма, которая принимает корр-ты двух точек в 2Д и выдает расстояние

// double GetDistance(int x1, int x2, int y1, int y2)
// {
//     double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
//     return distance;
// }

// Console.WriteLine("Input x1: ");
// int x1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Input x2: ");
// int x2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Input y1: ");
// int y1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Input y2: ");
// int y2 = int.Parse(Console.ReadLine());

// double result = GetDistance(x1, x2, y1, y2);
// Console.WriteLine(Math.Round(result, 2, MidpointRounding.AwayFromZero));

 //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

int [] GetSquareNumbers(int number)
{
    int [] squarenumbers = new int [number];

    for (int i = 1; i <= number; i++)
{
squarenumbers[i - 1] = i * i;
}
return squarenumbers;
}

Console.WriteLine("Input number: ");
int number = int.Parse(Console.ReadLine());

int [] result = GetSquareNumbers(number);
for (int i = 0; i < number; i++){
    Console.WriteLine(result[i]);
}