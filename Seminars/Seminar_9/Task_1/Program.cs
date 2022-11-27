void Rec(int n)
{
    
    System.Console.WriteLine($"Вход с n = {n}");
    if(n>=5)
    {
        System.Console.WriteLine($"Выход с n = {n}");
        return;
    }
    Rec(n+1);
    if (n == 3)
    {

    }    
    

    System.Console.WriteLine($"Выход с n = {n}");
    return;
}
Rec(1);