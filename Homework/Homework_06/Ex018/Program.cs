//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
//y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
double Accept(string message){
    System.Console.Write(message); 
    string readInput = System.Console.ReadLine();
    double result = Convert.ToDouble(readInput);
    return result;
}
double CoordX (double b1, double b2, double k1, double k2){
    double x = (-b2 + b1)/(-k1 + k2); //поиск координаты х
    return x;
}
double CoordY (double x, double b2, double k2){ 
    double y = k2 * x + b2; //поиск координаты У
    return y;
}
double b1 = Accept("введите значение b1 ");
double k1 = Accept("введите значение k1 ");
double k2 = Accept("введите значение k2 ");
double b2 = Accept("введите значение b2 ");
double x = CoordX (b1,b2,k1,k2);
double y = CoordY (x,b2,k2);
Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
