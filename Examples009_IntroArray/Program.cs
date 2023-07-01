Console.Write("Введите число ");
int find = int.Parse(Console.ReadLine());



int[] array = { 11, 22, 33, 44, 55, 66, 77, 44, 48, 29 };

int n = array.Length;


int index = 0;

while (index < n)

{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
