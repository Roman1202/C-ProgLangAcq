// 1й вид методов- ничего не принимает, ничего не возвращает
void Method1()
{
    Console.WriteLine("Learn more!");
}
Method1(); // такоим образом метод вызывается



// 2й вид методов- что-то принимает, ничего не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");
Method2(msg: "Текст сообщения"); // если метод принимает некое кол-во аргументов, то используются именованные аргументы, указывающие, какому аргументу какое значение хотим передать
// к предыдущему комментарию, например:
void Method21(string msg, int count) // сount покажет кол-во выводов msg на экран
{
    int i = 0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++; // инкремент, а уменьшение на 1- декремент
    }
}
Method21("Text", 4); // увидеть текст 4 раза
Method21(msg: "Text", count: 4); // можем указать явно, в таком случае, поряжок указания необязателен



// 3й вид методов- ничего не принимает, что-то возвращает
int Method3()
{
    return DateTime.Now.Year;
}
// попробуем вызвать
int year = Method3();
Console.WriteLine(year);



// 4й вид методов - что-то принимает, что-то возвращает
string Method4(int count, string text) // возвращать будем строку, строку "text" компоновать др за др "count" раз
{
    int i=0;
    string result = String.Empty; // или ...= ""; (пустая строка), изначально result будет пустой строкой
    
    while(i<count)
    {
        result=result+text;
        i++;
    }
    return result;
}
// вызовем
string res = Method4(10, "qwerty");
Console.WriteLine(res);