// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Вычислим функцию Аккермана");
Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");

int InputInt(string output){
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n){
    if (m == 0)return n + 1;
    if (n == 0 && m > 0  )return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine($"Функция({m}, {n}) = {Akkerman(m, n)}");