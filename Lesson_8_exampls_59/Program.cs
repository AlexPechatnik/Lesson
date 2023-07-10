/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
*/
int[,] array = new int[3, 3];
int minRow = 0;
int minCol = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine("");
}
int min = array[0, 0];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < min)
        {
            min = array[i, j];
            minRow = i;
            minCol = j;
        }
    }
}
System.Console.WriteLine($"Минимальное значение в массиве: {min} [" + minRow + ", " + minCol + "] ");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[minRow, j] != array[i, j] && array[i, minCol] != array[i, j])
        {
            System.Console.Write(array[i, j] + " ");
        }
    }
    System.Console.WriteLine("");
}