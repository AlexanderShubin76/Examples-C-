int a = 3;
int b = 5;
System.Console.WriteLine(Exponention(a, b));
int Exponention (int c, int d)
{
    
    if (d == 0) return 1;
    return a * Exponention(a, d-1);
}