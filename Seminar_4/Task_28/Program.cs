// Задача 28: Напишите программу, которая принимает
// на вход число N и выдаёт произведение чисел 
// от 1 до N.
// 4 -> 24
// 5 -> 120
int FindComposition (int number)
{
    int composition = 1;
    for (int i = 1; i <= number; i++)
    {
        composition *=i;
    }
    return composition;
}
int number1;
while(int.TryParse(Console.ReadLine(), out number1) && number1 == 1)
{
    System.Console.WriteLine("Введите число N >=1");
    int numberN;

    while(!int.TryParse(Console.ReadLine(), out numberN) || numberN < 1)
    {
        System.Console.WriteLine("Некорректное значение. Введите целое число больше нуля.");
    }
    System.Console.WriteLine(FindComposition(numberN));
}