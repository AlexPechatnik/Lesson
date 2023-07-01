// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int i = 0;
while (number > 0 )
    {
       number = number /10;
        i++;
    }

Console.WriteLine($"Колличество цифр в числе {i}");
