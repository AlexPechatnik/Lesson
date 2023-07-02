/*
Console.Write("Введите число ");
int nuber = int.Parse(Console.ReadLine());

string binar = " ";

while (nuber > 0)
{
    int temp = nuber % 2;
    binar = temp.ToString() + binar;
    nuber = nuber / 2;
}

Console.Write("Бинарное выражение: ");
Console.WriteLine(binar);
*/

Console.Write("Введите число ");
int nuber = int.Parse(Console.ReadLine());

int binar = 0;

while (nuber > 0)
{
    int temp = nuber % 2;
    binar = temp + binar;
    nuber = nuber / 2;
    Console.Write(binar);
}

