// Напишите программу, которая заменяет массив положительные на отрицательные:


int[] array = new int[12];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i] + " ");
}

Console.WriteLine();

int invertArray = 0;
for (int i = 0; i < array.Length; i++)
{
    invertArray = array[i] * -1;
    Console.Write(invertArray + " ");
}


Console.WriteLine();
Console.WriteLine("Comleted!");

