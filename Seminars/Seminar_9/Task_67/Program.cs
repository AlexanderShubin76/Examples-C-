// Задача 67: Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// string num = "1234";
// System.Console.WriteLine(SumNumbers(num));
// int SumNumbers (string number, int i = 0)
// {
//     if(i<number.Length) return int.Parse(number[i].ToString())+ SumNumbers(number, i+1);
//     else return 0;
// }

int num = 454;
System.Console.WriteLine(SumNumbers(num));
int SumNumbers (int number)
{
    if (number == 0) return number;
    return number % 10 + SumNumbers(number/10);
    
}