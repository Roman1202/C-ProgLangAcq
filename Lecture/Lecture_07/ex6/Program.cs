// Для того, чтобы работать с директориями, есть класс DirectoryInfo. Укажем путь к той папке, 
//свойства которой мы хотим узнать
string path = "C:/Users/Роман/Desktop/Csharp_4049Group/Lecture/Lecture_07/ex6";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime); //Узнать время создания папки
//обратимся к di и посмотрим какие файлы он содержит
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++){
    System.Console.WriteLine(fi[i].Name);
}