//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным (15)
int P(string message) // метод записи числа
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool Check(int number) //проверит, является ли введенное число днем недели
{
    if(number>0 && number<8)
    {
        return true;
    }
    Console.WriteLine("it's not a day of the week ");
    return false;
}
bool Weekend(int Day)
{
    if(Day>5)
    {
        return true;
    }
    return false;
}
int Day = P("Enter the serial number of the day of the week "); // метод ставит число из терминала
if (Check(Day)) //проверил является ли число порядковым дня недели
{
    if(Weekend(Day))// является ли выходным
    {
        Console.WriteLine("Netflix and Chill out ");
    }
    else 
    {
        Console.WriteLine("The sun is still high ");
    }
}