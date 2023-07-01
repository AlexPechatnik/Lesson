// Задайте массив. Напишиет программу, которая определяет, 
// присутствует ли заданное число в масиве



Console.WriteLine("Введите искомое число ");
int namber = int.Parse(Console.ReadLine());


int[] array = new int[12];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i] + " ");
}

Console.WriteLine();


for (int i = 0; i < array.Length; i++)
{
    if (namber == array[i])
    {
        Console.WriteLine("Искомое число присутсвует в массиве ");
        return;
    }
}

Console.WriteLine("Искомое число отсутствует в массиве");
Console.WriteLine();
Console.WriteLine("Comleted!");

