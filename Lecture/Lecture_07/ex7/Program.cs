// Напишем рекурсию которая будет ходить по папкам и рассматривать что там внутри
// метод CatalogInfo, аргументы: путь к папке (path), искуственный прием для отступов string indent = ""
void CatalogInfo(string path, string indent = ""){
    //получаем инф-ю о той директории в которую мы зашли по path
    DirectoryInfo catalog = new DirectoryInfo(path);
    // получаем массив всех файлов в этой папке, пробегаем по ним и выводя инф-ю о тек. каталоге
    // будем рекурсивно заныривать и смотреть все папки которые будут получены в catalogs
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for(int i = 0; i<catalogs.Length; i++){
        System.Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    // закончили вывод папок, получим весь список файлов тек. директории тек. каталога и покажем их
    FileInfo[] files = catalog.GetFiles();
    for(int i = 0; i< files.Length; i++){
        System.Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = "C:/Users/Роман/Desktop/Csharp_4049Group/Lecture/Lecture_07/ex6";
CatalogInfo(path);