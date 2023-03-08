
Console.Write("Enter a number: "); // выдача консоли
string number = Console.ReadLine(); // записанное сохраняется в переменную number

void CheckingNumber(string number) // метод, проверяющий, явл-ся число палиндромом или нет
{
  if (number[0]==number[4] && number[1]==number[3]) //
  {
    Console.WriteLine($"Your number: {number} - is a palindrome."); //интерполяция строк (${})
  }
  else Console.WriteLine($"Your number: {number} - isn't a palindrome.");
}

if (number.Length == 5) // если чисел 5, то
{
  CheckingNumber(number);
}
else Console.WriteLine($"Enter the correct number"); // интерполяция строк (${})


// Логические операторы выполняют логические операции с логическими операндами. 
// 1. Унарный ! (логическое отрицание) оператор.
// 2. Бинарные & (логическое И), | (логическое ИЛИ), а также ^ (логическое исключающее ИЛИ) операторы. 
//    Эти операторы всегда обрабатывают оба операнда.
//3. Бинарные && (условное логическое И) и || (условное логическое ИЛИ) операторы. 
//   Эти операторы вычисляют правый операнд, только если это необходимо.


