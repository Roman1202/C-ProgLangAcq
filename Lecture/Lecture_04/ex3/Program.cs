//печать массива и заполнение
void PrintArray(int[,] matr){//вывести в терминал
    for(int i=0; i<matr.GetLength(0); i++){ 
        for(int j=0; j<matr.GetLength(1); j++){
            System.Console.Write($"{matr[i, j]} ");
        }
    System.Console.WriteLine();
    }
}

void FillArray(int[,]matr){//заполнить случ числами
    for(int i=0; i<matr.GetLength(0); i++){
        for(int j=0; j<matr.GetLength(1); j++){
            matr[i,j] = new Random().Next(1,10);
        }
    }
}
int[,] matrix = new int[3,4];
PrintArray(matrix);
System.Console.WriteLine();//разделим матрицы строкой
FillArray(matrix);
PrintArray(matrix);