// сумма чисел от 1 до n. Итеративно и с рек-ей
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1); //вызывает саму себя и описаны условия выхода
}
System.Console.WriteLine(SumFor(10));// 55
System.Console.WriteLine(SumRec(10));// 55