// 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int Accept(string message){
    System.Console.Write(message); 
    string readInput = System.Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}
void FillArrayRandomNumbers(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){        
            for (int j = 0; j < array.GetLength(1); j++){
                array [i,j] = new Random().Next(-200, 200)/10;
            }   
        }
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

int n = Accept("введите номер строки ");
int m = Accept("введите номер столбца ");
int [,] numbers = new int [10,10];

FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1)){
    Console.WriteLine("такого элемента нет");
}
else{
    Console.WriteLine($"значение элемента {n} строки и элемента {m} столбца равно {numbers[n-1,m-1]}");
}

PrintArray(numbers);