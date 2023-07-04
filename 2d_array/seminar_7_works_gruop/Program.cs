/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/
int m = 3;
int n = 4;

int[,] GetFillAmnMatrix(int width, int height)
{
    int[,] new_array = new int[width, height];

    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            new_array[i, j] = i + j;
        }
    }
    return new_array;
}

void PrintAmnMatrix (int[,] imputMatrix)
{
    for (int i = 0; i < imputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < imputMatrix.GetLength(1); j++)
        {
            Console.WriteLine(imputMatrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
PrintAmnMatrix(GetFillAmnMatrix(m, n));
