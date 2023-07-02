/*
Напишите программу, которая принимает на вход 3 числа и проверяет, может ли
существовать треугольник с сторонами такой длины.
*Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*
*/
Console.WriteLine("Введите длину a ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину b ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину c ");
int c = int.Parse(Console.ReadLine());

while (a < c + b && b < c + a && c < b + a)
{
    if (true)
    {
        Console.WriteLine("Такой треугольник может существовать ");
        return;
    }
}
Console.WriteLine("Такой треугольник не может существовать ");
return;