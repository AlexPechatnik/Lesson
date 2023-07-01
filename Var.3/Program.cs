Console.Write("Введи трехзначное число: ");
int numberA = int.Parse(Console.ReadLine());
int result = numberA % 10;
Console.WriteLine($"последняя цифра = {result}");