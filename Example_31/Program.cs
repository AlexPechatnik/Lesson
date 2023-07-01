// Задайте масив из 12 элементов, заполненный случайными цифрами и [-9,9]

int[] GetRandomArray(int size, int startValue, int endValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(startValue, endValue + 1);
    }
    return array;

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

/* Превратили в метод
int[] array = new int[12];
Console.Write("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i] + " ");
}
*/
int[] array = GetRandomArray(12, -9, 9);
PrintArray(array);

Console.WriteLine();

int sum_positive = 0;
int sum_negative = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum_positive = sum_positive + array[i];
    }

    if (array[i] < 0)
    {
        sum_negative = sum_negative + array[i];
    }
}


Console.WriteLine($"Сумма положительных чисел = {sum_positive}");
Console.WriteLine($"Сумма отрицательных чисел = {sum_negative}");