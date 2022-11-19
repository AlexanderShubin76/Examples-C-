// Напишите программу, которая принимает на вход трехзначное число
//  и на выходе показывает последнюю цифру этого числа
// int ExArray(int [] collection)
// {
//     int result = collection[2];
//     return result
// }
// int [] array = double.Parse(Console.ReadLine()!);
// int pos = ExArray(array);
// System.Console.WriteLine(pos);
int GetLastDigit(int number)
{
    return number % 10;
}
int testNumber = 7532;
System.Console.WriteLine(GetLastDigit(testNumber));
void DoNothing()
{
    System.Console.WriteLine("Start");
    Console.WriteLine("End");
}
DoNothing();