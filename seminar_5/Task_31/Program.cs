﻿// // Задача 31: Задайте массив из 12 элементов,
// заполненный случайными числами из промежутка
// [-9,9]. Найдите сумму отрицательных и положительных
// элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20. 

int length = 12;
int [] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

int number;
string text = "Введите значение 1 для запуска программы "
+ "или любое другое значение для остановки программы.";

System.Console.WriteLine(text);

while (int.TryParse(Console.ReadLine(), out number) && number==1)
{  
    System.Console.WriteLine(string.Join(", ", GetArray(length)));
    System.Console.WriteLine(text);
}
