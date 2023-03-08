int[] arr = {1,34,5,7,43,7,23}; // упорядочим массив по возрастанию
// решим подзадачу которая будет отвечать за то, чтобы вывести данный массив на экран- напишем метод:
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i=0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//протестируем
//PrintArray(arr);
//теперь напишем метод, который будет упорядочивать наш массив:
void SelectionSort(int[] array)
{
    for(int i=0; i<array.Length - 1; i++)
    {   //определяем позицию на которую смотрим:
        int minPosition = i; 
        //ищем минимальный элемент:
        for(int j=i+1; j<array.Length; j++)
        {
            if(array[j] < array[minPosition]) 
            {
                minPosition = j; //блок для поиска мин. элемента из неотсортир-го массива
            }       
        }//обмен двух переменных местами (текущей с найденной минимальной):
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr); // выводит начальный массив
SelectionSort(arr);// сортирует его по возрастанию
PrintArray(arr);// выводит уже отсортированный массив на экран