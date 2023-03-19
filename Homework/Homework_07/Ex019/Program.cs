// 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int Accept(string message){
    System.Console.Write(message); 
    string readInput = System.Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}

void FillArray(double[,] array){ //генерация и запоминание значений
    for (int i = 0; i < array.GetLength(0); i++){ //GetLength(0)возвращает количество строк
        for (int j = 0; j < array.GetLength(1); j++){ //GetLength(1)возвращает количество столбцов         
            array[i, j] = Convert.ToDouble(new Random().Next(-20, 20)) / 10; //деление, видимо, для дробных чисел
        }
    }
}

void PrintArray(double[,] array){// вывод чисел, сгенерированных в предыдущем методе
    for (int i = 0; i < array.GetLength(0); i++){
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");//перенос на следующую строку
    }
}

int lines = Accept("Введите количество строк ");
int columns = Accept("Введите количество столбцов ");
double[,] numbers = new double[lines, columns];
FillArray(numbers);
PrintArray(numbers);