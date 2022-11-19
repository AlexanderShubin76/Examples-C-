// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
// int number = new Random().Next(10,100);
// System.Console.WriteLine(number);
// FindNumber
// int last_number = number % 10;
// int first_number = number / 10;
// int max = last_number;
// if (first_number > max) max = first_number;
// System.Console.WriteLine(max);
int FindBiggerNumber(int number)
{
    int last_number = number % 10;
    int first_number = number / 10;
    int max = last_number;
    if (first_number > max) max = first_number;
    return max;
}
int Number = new Random().Next(10,100);
System.Console.WriteLine(Number);
System.Console.WriteLine(FindBiggerNumber(Number));
