//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
double Ac(string message){
    System.Console.Write(message); 
    string readInput = System.Console.ReadLine();
    double result = Convert.ToDouble(readInput);
    return result;
}
double[] Gen(double length, double min, double max){
    double[] array = new double[length];
    Random random = new Random();
    for(int i = 0; i<length; i++){
        array[i] = random.Next(min, max+1);
    }
    return array;
} 
void Pr(double[] array){
    System.Console.Write("[");
    for(int i=0; i<array.Length-1; i++){
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("] ");
}
double Search1(double[] Ar){
    double length = Ar.Length;
    double min = Ar[0];
    for(int i = 1; i<length; i++){
        if(Ar[i]<min)min=Ar[i];
    }
    return min;
}
double Search2(double[] Ar){
    double length = Ar.Length;
    double max = Ar[0];
    for(int i = 1; i<length; i++){
        if(Ar[i]>max)max=Ar[i];
    }
    return max;
}
double Dif(double min, double max){
    double dif = max - min;
    return dif;
}
System.Console.WriteLine("Зададим массив вещественных чисел и найдем разницу между мин. и макс. значением его элементов ");
double length = Ac("Введите длину массива");
double min = Ac("Введите число - минимальное значение диапазона случайных чисел массива ");
double max = Ac("Введите число - максимальное значение диапазона случайных чисел массива ");
double[] Ar = Gen(length, min, max);
Pr(Ar);
Search1(Ar);
Search2(Ar);
System.Console.WriteLine($"Разность мин. и макс. чисел равна {Dif(min, max)}");