double[] array = new double[5];
double[] arrayCoppy = new double[array.Length];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round((new Random().NextDouble() * new Random().Next(0, 10)), 2);
    Console.Write(array[i] + " | ");
}

Console.WriteLine(" ");


for (int i = 0; i < array.Length; i++)
{
    arrayCoppy[i] = array[i];
    Console.Write(arrayCoppy[i] + " | ");
}
