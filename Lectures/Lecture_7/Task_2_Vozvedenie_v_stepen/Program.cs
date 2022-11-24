// int PowerFor(int a, int n)
// {
//     if (n==0) return 1;
//     else return a*(PowerFor(a, n-1));
// }
int PowerFor(int a, int n)
{
    if (n==0) return 1;
    else if (n % 2 == 0) return PowerFor(a*a, n/2);
    else return a*(PowerFor(a, n-1));
}
System.Console.WriteLine(PowerFor(3, 5));