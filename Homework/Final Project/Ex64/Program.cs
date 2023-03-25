// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии
System.Console.WriteLine("Выведем все натуральные числа от N до 1");
nt n = InputInt("Введите положительное число ");
int m = 1;

int InputInt(string output){
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

if (n < 1){
    Console.WriteLine("Число не положительное");
}
Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m){
    if (n == m)return n;
    else Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}
