// Задача 26:
// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
void FindQuantity(string number)
{      
    return number.Length;
}
int number1;
while (int.TryParse(Console.ReadLine(), out number1) && number1 ==1)
{
    System.Console.WriteLine("Введите число от 1 до N");
    string num = Console.ReadLine()!;
    System.Console.WriteLine(FindQuantity(num));
}
