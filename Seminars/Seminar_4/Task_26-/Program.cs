// Задача 26:
// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
// int FindQuantity(string number)
// {      
//     return number.Length;
// }
// int number1;
// while (int.TryParse(Console.ReadLine(), out number1) && number1 ==1)
// {
//     System.Console.WriteLine("Введите число от 1 до N");
//     string num = Console.ReadLine()!;
//     System.Console.WriteLine(FindQuantity(num));
// }
void FindQuantity(int number)
{
if (number>=0 && number < 10)
    System.Console.WriteLine($"1");
else
{
    int count=1;    
    while(number/10>=1)
    {
        number /= 10;
        count++;
    }
    System.Console.WriteLine(count);
}
}


int number1;

while(int.TryParse(Console.ReadLine(), out number1) && number1 == 1)
{
    System.Console.WriteLine("Введите число N >=0");
    int numberN;

    while(!int.TryParse(Console.ReadLine(), out numberN) || numberN < 0)
    {
        System.Console.WriteLine("Некорректное значение. Введите целое число больше двух.");
    }
    FindQuantity(numberN);
}