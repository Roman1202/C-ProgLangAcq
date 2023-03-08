int x1 = Coordinate("x", "A"); //приравниваем координаты переменным
int y1 = Coordinate("y", "A"); // аргументы в кавычках, тк показывают строки а не целые числа
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string NameOfCoord, string NameOfPoint)//задаем значения двух точек в трех плоскостях
{
    Console.Write($"Введите координату {NameOfCoord} точки {NameOfPoint}: "); //интерполяция строк (${})
    return Convert.ToInt16(Console.ReadLine());//конвертируем ввод из int в string
}

double Decision(double x1, double x2, //данные в double чтобы получать дробные числа
                double y1, double y2, 
                double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + //Math. Sqrt() – математическая функция которая извлекает квадратный корень. 
                   Math.Pow((y2-y1), 2) + //В аргументных скобках указывается значение числа, из которого нужно извлечь квадратный корень. Math.
                   Math.Pow((z2-z1), 2));
}  //Math. Pow() – возведения числа в степень. В аргументных скобках через запятую указываются два аргумента 
//(1-ый аргумент - число, которое возводим в степень, 2-ой – степень, в которую возводим число).
double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );
//Math.Round-  Округляет значение до ближайшего целого или указанного количества десятичных знаков.
Console.WriteLine($"Длина отрезка  {segmentLength}");