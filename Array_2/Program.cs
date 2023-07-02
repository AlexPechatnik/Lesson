// See https://aka.ms/new-console-template for more information
double[] array = new double[50];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round ((new Random().NextDouble() * new Random().Next(0, 10)), 2);
    Console.Write(array[i] + " / ");
}

double min = array[0];
for (int i = 0; 1<array.Length;i++)
{
    if (array[i]<min)
    {
        min = array[i];
    }
}

Console.WriteLine(min);
