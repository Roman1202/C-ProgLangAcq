int Accept(string message){
    System.Console.WriteLine(message); //предложение ввести число
    string readInput = System.Console.ReadLine();//ввод приравнивается к переменной
    int result = int.Parse(readInput);//приводим строку к числу
    return result;//возвращаем результат
}
int Power(int powerBase, int exponent){
    int power = 1;
    for(int i = 0; i < exponent; i++){//пока i меньше степени, 
        power *= powerBase;//счетчик power = power*первое число, пока i не сравняется со степенью
    }
    return power;
}
bool ValidExponent(int exponent){
    if(exponent<0){
        System.Console.WriteLine("Степень (число В) не может быть меньше нуля");
        return false;
    }
    return true;
}
int powerBase = Accept("Введите основание: ");//введенное число сохраняется в переменную
int exponent = Accept("Введите степень: ");//введенная степень сохраяется в переменную
if(ValidExponent(exponent)){
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}