// вычислить a в степени n итеративно и с рекурсией (и тернарный оператор)
int PowerFor(int a, int n){
    int result = 1;
    for(int i = 1; i<=n; i++) result *= a;
    return result;
}
int PowerRec(int a, int n){
    //return n == 0 ? 1 : PowerRec(a, n-1) * a; - использовали тернарный оператор (1 line instead 2, or)
    if(n==0) return 1;
    else return PowerRec(a, n-1) * a;
}
System.Console.WriteLine(PowerFor(1, 10)); //1024
System.Console.WriteLine(PowerRec(1, 10)); //1024
// или так
int PowerMathRec(int a, int n){
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerMathRec(a * a, n / 2);
    else return PowerMathRec(a, n - 1) * a;
}