// обход разных структур, бинарное дерево выражения ((4-2)*(1+3))/10
string emp = String.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//метод для обхода, аргумент- позиция с которой начинаем
void InOrderTravesal(int pos = 1){
    //если позиция вылетела за кол-во эл-ов то рекурсия закончена
    if(pos<tree.Length){
        //если первый аргумент с индексом i, то дочерние с индексами 2i и 2i+1 соотв-но
        //считаем позицию левого и правого поддерева
        int left = 2 * pos;
        int right = 2 * pos + 1;
        //проверка-если левое поддерево имеется, и хранимый в нем элемент не является пустым, то рекурсивно 
        //запускаем обход того дерева с текущей позиции
        if(left<tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTravesal(left);
        //выводим узел
        System.Console.WriteLine(tree[pos]);
        //и аналогично для правого поддерева
        if(right<tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTravesal(right);
    }
}
//запусттим и получим обход нужных нам узлов
InOrderTravesal();