Console.WriteLine("Принимаем на вход два числа (A и B) и возводим число A в натуральную степень B");
int Accept(string message){
    System.Console.Write(message); //предложение ввести число
    string readInput = System.Console.ReadLine();//ввод приравнивается к переменной
    int result = int.Parse(readInput);//приводим строку к числу
    return result;//возвращаем результат
}

int Exponentiation(int Base, int exponent){
    int counter = 1;
    for(int i = 0; i < exponent; i++){//пока i меньше степени, 
        counter *= Base;//счетчик counter = counter*первое число, пока i не сравняется со степенью
    }
    return counter;
}
//double MP(double A, double B)
{
   // return Math.Pow(A, B);
}
int numberA = Accept("Введите число ");
int numberB = Accept("Введите степень ");
//double result = MP(numberA, numberB);
int result = Exponentiation(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {result}");