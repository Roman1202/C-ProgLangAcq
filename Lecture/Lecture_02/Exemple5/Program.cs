int[] a={2,4,3,7,5,8}; // найти индекс со значением 7
int n = a.Length;
int find=7;
int i=0;
while (i<n)
{
    if(a[i]==find)
    {
        Console.WriteLine(i);
    }
    i++;
}