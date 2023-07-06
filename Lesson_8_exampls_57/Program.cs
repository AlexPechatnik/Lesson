/* Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
*/
int[,] array = new int[5, 5];
int count0=0;
int count1=0;
int count2=0;
int count3=0;
int count4=0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 4);
        System.Console.Write(array[i, j]+" ");
        if(array[i,j]==0)
        {
            count0++;
        }
         if(array[i,j]==1)
        {
            count1++;
        }
         if(array[i,j]==2)
        {
            count2++;
        }
         if(array[i,j]==3)
        {
            count3++;
        }
         if(array[i,j]==4)
        {
            count4++;
        }
    }
    System.Console.WriteLine(" ");
}

System.Console.WriteLine("Частоточный массив: ");
System.Console.WriteLine($"0 встречается {count0} раз(а)");
System.Console.WriteLine($"1 встречается {count1} раз(а)");
System.Console.WriteLine($"2 встречается {count2} раз(а)");
System.Console.WriteLine($"3 встречается {count3} раз(а)");
System.Console.WriteLine($"4 встречается {count4} раз(а)");
