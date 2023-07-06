/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
*/
int[,] array = new int[5, 5];
int [,] point = new int [array.GetLength(0), array.GetLength(1)];
int min = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 9);
        System.Console.Write(array[i, j] + " ");
        int temp = array[i, j];
        if (array[i, j] < temp)
        {
            min = temp;
            point[i,j] = array[i, j];
            System.Console.WriteLine(point[i,j]);
        }

    }
    System.Console.WriteLine("");

}
