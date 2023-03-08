string Method4(int count, string text) // возвращать будем строку, строку "text" компоновать др за др "count" раз
{
    string result = String.Empty; // или ...= ""; (пустая строка), изначально result будет пустой строкой
    
    for(int i=0; i<count; i++) // сократили программу на 3 строки
    {
        result=result+text;
    }
    return result;
}
// вызовем
string res = Method4(10, "qwerty");
Console.WriteLine(res);