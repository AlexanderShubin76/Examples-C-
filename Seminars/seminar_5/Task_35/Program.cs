// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество двухзначных элементов массива.
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



int length = 123;
int [] massive = GetArray(length);
PrintArray(massive);

int quantity = QuantityOfTwoDigitNumbers(massive);
System.Console.WriteLine(quantity);

int QuantityOfTwoDigitNumbers(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item > 9 && item<100)
        {
            count++;
        }
        else continue;
    }
    return count;
}

int [] GetArray (int length, int minValue = 0, int maxValue = 124)
{
    int [] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,124);
    }
    return array;
}
void PrintArray (int[] array)
{
    System.Console.WriteLine(string.Join(", ", array));
}
