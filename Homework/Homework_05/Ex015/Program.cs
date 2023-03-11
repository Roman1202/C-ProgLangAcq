//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях(36)
int Accept(string message){
    System.Console.Write(message); 
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int[] Generate(int length, int min, int max){
    int[] array = new int[length];
    Random random = new Random();
    for(int i = 0; i<length; i++){
        array[i] = random.Next(min, max+1);
    }
    return array;
} 
void Print(int[] array){
    System.Console.Write("[");
    for(int i=0; i<array.Length-1; i++){
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("] ");
}
int Sum(int[] array){
    int length = array.Length;
    int counter = 0;
    for(int i=1; i<length; i=i+2){
        counter=counter+array[i];
    }
    return counter;
}
System.Console.WriteLine("Создадим массив со случайными числами и суммируем значения его элементов на нечетной позиции");
int length = Accept("Введите длину массива ");
int min = Accept("Введите число - минимальное значение диапазона случайных чисел массива ");
int max = Accept("Введите число - максимальное значение диапазона случайных чисел массива ");
int[] array = Generate(length, min, max);
Print(array);
System.Console.WriteLine($"Сумма значений элементов массива в нечетных позициях равна {Sum(array)}");