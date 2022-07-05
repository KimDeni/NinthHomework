int Sum(int n, int m){

    if(n < m){
        
        n += Sum(n + 1, m);
    }

    return n;
}

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{"Сумма элементов равна:"} {Sum(n,m)}");