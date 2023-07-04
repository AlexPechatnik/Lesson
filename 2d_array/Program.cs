





Console.WriteLine("Entet num roms:");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Entet num colmns:");
int colmns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = IniMatrix(rows, colmns);

Print(matrix);

int[,] IniMatrix(int rows, int colmns)
{
    int[,] tmp = new int[rows, colmns];
    Random random = new Random();
    {
        for (int i = 0; i < rows; i++)
        {
            for ( int l = 0; l < colmns; l++)
            {
                tmp[i, l] = random.Next(10, 101);
            }
        }
        return tmp;
    }
}
void GetMatrix(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int l = 0; l < arr.GetLength(1); l++)
        {
            arr[i, l] = random.Next(1, 101);
        }
    }
}

void Print(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int l = 0; l < arr.GetLength(1); l++)
        {
            Console.Write($"{arr[i, l]} ");
        }
        Console.WriteLine();
    }
}
