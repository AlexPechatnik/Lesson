/*Задача 49: Задайте двумерный массив. Найдите элементы, 
у которых оба индекса чётные, и замените эти элементы на их квадраты.
*/

int[,] array = new int[10, 10];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10); ;
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
}

for (int i = 0; i < array.GetLength(1); i++)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
       sum = sum + array[i, j];
    }
    System.Console.WriteLine($"Средняя ариф. строки {i}: {sum / array.GetLength(1)}");
}
