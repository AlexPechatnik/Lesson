/*Задайте одномерный массив из 123 случайных чисел.
Найти количество элементов массива, значения которых лежат в отрезке [10-99]
*/


int[] array = new int[123];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 124);
}

Console.WriteLine();
int range = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i]> 10 && array[i]<99)
    range = range+1;
}



Console.WriteLine($"Значения которых лежат в отрезке 10-99 = {range}");
Console.WriteLine();
Console.WriteLine("Comleted!");
