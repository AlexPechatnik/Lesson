/*
Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
*/

int[,] array = new int[5, 5];
int[,] temp = new int[5, 5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10); ;
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = temp[i, j];
        System.Console.Write(temp[i, j]);
    }
    System.Console.Write(" ");
}
