class Program
{

    static int Sum(int value_1, int value_2)
    {
    return value_1 + value_2;
    }
    static void Main(string[] args)
    {
        int a, b, c;
        a= int.Parse(Console.ReadLine());
        b= int.Parse(Console.ReadLine());
        c = Sum(a, b);
        Console.WriteLine(c);
    }
}
