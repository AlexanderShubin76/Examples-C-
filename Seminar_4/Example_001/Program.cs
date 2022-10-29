// Напишите программу, 
// которая принимает на вход число (А) 
// и выдает сумму чисел от 1 до А.
int SumFrom1toA (int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int SumFrom1toAFast(int number)
{
    int sum = (1 + number) * number / 2;
    return sum;
} 


int number1;
while (int.TryParse(Console.ReadLine(), out number1) && number1 ==1)
{
    System.Console.WriteLine("Введите число от 1 до А");
    int numberA;

    while (!int.TryParse(Console.ReadLine(), out numberA) || numberA<=1)
    {
        System.Console.WriteLine("Некорректное значение, введите число >= 1");
    }
    System.Console.WriteLine(SumFrom1toA(numberA));
    System.Console.WriteLine(SumFrom1toAFast(numberA));
}