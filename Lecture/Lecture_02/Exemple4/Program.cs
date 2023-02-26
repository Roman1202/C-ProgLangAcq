int Max(int arg1, int arg2, int arg3) // найти max из 9и чисел (use array)
{
    int result = arg1;
    if(arg2>result) result=arg2;
    if(arg3>result) result=arg3;
    return result;
} //           0  1 2  3 4  5 6  7 8
int[] a = {15,2,53,4,95,6,73,8,19};


int max = Max(
    Max(a[0],a[1],a[2]),
    Max(a[3],a[4],a[5]),
    Max(a[6],a[7],a[8])
);
Console.WriteLine(max);