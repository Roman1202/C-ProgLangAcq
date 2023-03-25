// написать слова из Т букв, которые можно построить из набора символов
    // попробуем для 4х букв:
char[] s = { 'й', 'а', 'у', 'х'};
int count = s.Length;
int n = 1;
for(int i = 0; i < count; i++)
{
    for(int j = 0; j < count; j++)
    {
        for(int k = 0; k <count; k++)
        {
            for(int l = 0; l < count; l++)
            {
                System.Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}");
            }
        }
    }
}
// ОБЩЕЕ РЕШЕНИЕ 
int b = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        System.Console.WriteLine($"{b++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("лвмо", new char[4]); // получаем список слов из [n] букв используя " " алфавит 