//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве(34)
int Accept(string message){
    System.Console.Write(message); 
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int[] Generate(int length, int minRange, int maxRange){
    int[] array = new int[length];
    Random random = new Random();
    for(int i = 0; i<length; i++){
        array[i] = random.Next(minRange, maxRange+1);
    }
    //System.Console.WriteLine($"Новый созданный массив: {array}");
    return array;
} 
void Print(int[] array){
    System.Console.Write("[");// открыть скобки
    for(int i=0; i<array.Length-1; i++){
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");//последнее число массива специально отдельно, 
    System.Console.Write("] ");//закрыть скобки             чтобы не ставить запятую
}
int Sum(int[] array){
    int length = array.Length;
    int counter = 0;
    for(int i=0; i<length; i++){
        if(array[i] % 2 == 0){
            counter++;    
        }   
    } 
    return counter;
}
System.Console.WriteLine("Зададим массив заполненный случайными положительными трёхзначными числами и покажем количество чётных чисел в массиве");
int length = Accept("Введите длину массива ");
int min = 100;
int max = 999;
int[] array = Generate(length, min, max);
Print(array);
System.Console.WriteLine($"Количество четных чисел в массиве равно {Sum(array)}");