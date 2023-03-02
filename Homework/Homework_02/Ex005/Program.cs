 //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа (10)
int P(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int n = P("enter a three-digit number ");
if (n<100 || n>999)
{
    Console.WriteLine("It's not a three-digit number, write it again");
    return;
}
int s = n/10%10;
Console.WriteLine("Second number is " + (s));
