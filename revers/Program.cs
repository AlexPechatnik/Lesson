/*
int[] array = new int[9] { 1, 4, 5, 7, 8, 2, 0, 9, 2 };
int[] reversArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    reversArray[i] = array[(array.Length-1)-i];
    Console.Write(reversArray[i]+ " ");
}
*/

int[] array = new int[8] { 1, 4, 5, 7, 8, 2, 0, 9 };
for (int i = 0; i < array.Length/2; i++)
{
    int temp = array[i];
    array[i] = array[(array.Length-1)-i];
    array[(array.Length-1)-i] = temp;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+" ");
}
