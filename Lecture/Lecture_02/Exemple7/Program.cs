void FillArray(int[]collection) // метод заполнения массива и вывода его на экран
{
    int length = collection.Length;
    int i=0;
    while (i<length)
    {
        collection[i]=new Random().Next(1, 10);
        i++;
    }
}

void PrintArray(int[] col)
{
    int count= col.Length;
    int position= 0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;

    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);