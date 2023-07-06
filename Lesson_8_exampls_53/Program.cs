/*
Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
*/

int[,] array = new int[,] {{1,2,3},{4,5,6},{7,8,9}};

int line1 = 0;
int line3 = 2;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

for (int i = 0; i < array.GetLength(1); i++)
{
    int temp = array[line1, i];
    array[line1, i] = array[line3, i];
    array[line3,i] = temp;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();