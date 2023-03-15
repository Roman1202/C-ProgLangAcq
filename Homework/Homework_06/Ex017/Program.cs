//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь(41)
int Accept(string message){
    System.Console.Write(message); 
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int[]Array(int length){ //заполняет массив данными с терминала
    int[]array=new int[length];
    for(int i=0; i<array.Length; i++){
        array[i]=Accept($"Введите {i+1}-й элемент ");
    }
    return array;
}
void Print(int[] array){//определяет для каждого индекса свой элемент
    for(int i=0; i<array.Length; i++){
        System.Console.WriteLine($"a[{i}] = {array[i]}");
    }
}
int Count(int[] array){
    int count = 0;
    for(int i=0; i< array.Length; i++){
        if(array[i]>0)count++;
    }
    return count;
}
int length= Accept("Введите количество элементов ");
int[]array;
array=Array(length);
Print(array);
System.Console.WriteLine($"Количество чисел больше нуля равно- {Count(array)}");