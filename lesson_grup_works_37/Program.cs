/*
Найти прозиведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и прдепоследний и тд.
*/
int[] array = new int[3];
int[] arrayMult = null;

if  (array.Length %2 == 0)
{
    arrayMult = new int [array.Length /2];
}
else
{
   arrayMult = new int [array.Length /2 +1];
}


Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
}

Console.WriteLine();
int a = array.Length;
int size = array.Length -1;


for (int i = 0; i <= size / 2; i++)
{
    if (i != array.Length / 2)
    {
        arrayMult[i] = (array[i] * array[a - 1]);
        a--;
        Console.Write(arrayMult[i] + " ");
    }
    if (i < array.Length / 2)
    {
        arrayMult[i] = (array[i]) * 1;
        a--;
        Console.Write(arrayMult[i] + " ");
    }
}



Console.WriteLine();
Console.WriteLine("Comleted!");