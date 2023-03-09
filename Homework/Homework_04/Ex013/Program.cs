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
    return array;//возвращает массив
} 
void Print(int[] array){
    System.Console.Write("[");// открыть скобки
    for(int i=0; i<array.Length-1; i++){
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");//последнее число массива специально отдельно, 
    System.Console.Write("]");//закрыть скобки             чтобы не ставить запятую
}
int length = Accept("Введите длину массива ");
int minRange = Accept("Диапазон массива из случайных чисел начинается с (число)- ");
int maxRange = Accept("Диапазон массива из случайных чисел заканчивается на (число)- ");
int[] array = Generate(length, minRange, maxRange);//заполнили массив случайными числами
Print(array);//вывели массив в терминал
//Если Вам подходит генерация псевдо-случайных чисел, можно воспользоваться классом Random. 
//При создании более одного случайного числа все же предпочтительно создать один раз экземпляр класса
//Random, и потом генерировать новые значения с помощью метода random.Next(). Потому что если между созданиями
//экземпляров класса будет небольшой промежуток времени у Вас будут повторяющиеся случайные числа.