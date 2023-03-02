//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет (13)
int P(string message) // метод записи числа
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int Find(int number) // метод нахождения 3го числа(делит число на 10 пока выполняется условие, после %10 - число найдено)
{
    while (number>999)
    {
        number /= 10;
    }
    return number % 10;
}

bool Check(int number)
{ // проверяет, является ли число менее чем 3-значным, или нет
    if(number<100)
    {
        Console.WriteLine("The third digit is missing, please try again");
        return false;
    }
    return true;
}

int number = P("Write a number "); //метод вставляет число из терминала
if (Check(number)) //метод проверяет число на применимость в условии 
{
    Console.WriteLine(Find(number)); // метод находит третье число при соблюдении true в условии
}