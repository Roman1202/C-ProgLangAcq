﻿int[] a={2,4,3,7,5,8,7}; // найти индекс со значением 7 
int n = a.Length;
int find=7;
int i=0;
while (i<n)
{
    if(a[i]==find)
    {
        Console.WriteLine(i);
        break; // т.к. в массиве несколько значений 7, но нам нужно найти только индекс первого иск. значения в массиве
    }
    i++;
}