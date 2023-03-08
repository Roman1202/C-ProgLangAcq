Console.WriteLine("Принимаем на вход число (N) и выдаём кубы чисел от 1 до N");
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine()); //конвертируем ввод из string в int

void Cube(int[] cube)//метод для возведения каждого индекса в куб(индексы массива-от нуля(как указано ниже) до cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter <  length)
  {// Math.Pow(counter, 3)- возведение индекса массива в степень 3:
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));//приравнивает кубы к значениям массива-заполняет его
    counter++;
  }
}

void PrintArry(int[] coll)//метод выводит значения массива в терминал
{
  int count = coll.Length;//предположительно, программа принимает в count ук-ное число тк опирается на "coll"
  int index = 0;
  while(index < count)
  {
    Console.Write(coll[index]+ " ");//значение+пробел (конкотенация)
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);// сначала метод считает кубы и заполняет значения ранее пустого массива с длиной cube
PrintArry(arry);// потом выводит по очереди значения массива, заполненного ранее