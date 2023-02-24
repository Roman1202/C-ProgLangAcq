Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "алиса")
{ 
    Console.WriteLine("Ура, это же АЛИСА!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}