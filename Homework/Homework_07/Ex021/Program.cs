// 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int Accept(string message){
    System.Console.Write(message); 
    string readInput = System.Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}

void FillArrayRandomNumbers(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


int n = Accept("введите количество строк ");
int m = Accept("введите количество столбцов ");
int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);

for (int j = 0; j < numbers.GetLength(1); j++){ //перебираем цикл для каждого столбца
    double avarage = 0;//счетчик
    for (int i = 0; i < numbers.GetLength(0); i++){
        avarage = (avarage + numbers[i, j]);//складываем по очереди значения каждой строки конкретного столбца
    }
    avarage = avarage / n; //получаем СА делением суммы столбца на число строк (равно кол-ву чисел из суммы)
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);