// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int a = number;
int result = 1;
while (a > 0)
{
    result = result * a;
    a--;
}



Console.WriteLine(result);
