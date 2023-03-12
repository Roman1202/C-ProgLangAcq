int Factorial(int n){
    if(n==1) return 1;
    else return n * Factorial(n-1);//System.Console.WriteLine(Factorial(40)); or
}
for(int i = 1; i<40; i++){
    System.Console.WriteLine($"{i}! = {Factorial(i)}");
}

