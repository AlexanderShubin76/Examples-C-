// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
// int M1 = 4;
int N1 = 8;

Numbers(N1);
void Numbers(int N, int M=1)
{
    System.Console.Write($"{M}");
    if (M == N)
    {
        return;
    }
    System.Console.Write(", ");
    Numbers(N, M+1);
}
