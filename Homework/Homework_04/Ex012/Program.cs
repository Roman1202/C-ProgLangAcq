int Accept(string message){
    System.Console.Write(message); //предложение ввести число
    string readInput = System.Console.ReadLine();//ввод приравнивается к переменной
    int result = int.Parse(readInput);//приводим строку к числу
    return result;//возвращаем результат
}
int Sum(int number){
    int result = 0;
    while(number>0){
        result += number%10;
        number = number/10;
    }
    return result; 
}
System.Console.WriteLine("Принимаем на вход число и выдаём сумму цифр в числе");
int number = Accept("Введите число ");
System.Console.WriteLine($"Сумма всех цифр в числе {number} равна {Sum(number)}");