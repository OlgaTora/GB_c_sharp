void CompareDigits()
    {
    int x = new Random().Next(10, 100);
    int x1 = x / 10;
    int x2 = x % 10;
    Console.WriteLine($"Сгенерировано число {x}");
    if (x1 > x2) Console.WriteLine("Первое");
    else if (x2 > x1) Console.WriteLine("Второе");
    else Console.WriteLine("Палиндром");
    }
 CompareDigits();