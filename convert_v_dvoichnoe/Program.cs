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


