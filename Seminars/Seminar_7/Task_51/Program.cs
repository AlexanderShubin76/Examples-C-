// Задача 51: Задайте двумерный массив, заполните его случайными числами. Найдите сумму элементов на главной диагонали (главная диагональ – это те элементы, которые имеют индекс (0, 0), (1, 1)…).
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int[,] array = GetArrayRandom(3,4);
PrintArray(array);
System.Console.WriteLine(GetSumElementsArray(array));

int[,] GetArrayRandom(int rows, int cols, int minValue = 0, int maxValue = 9)
{
    int[,] array = new int[rows, cols];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue +1 );
        }
    }

    return array;
}

int GetSumElementsArray(int[,] massive)
{
    
    int sumElements = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sumElements +=massive[i,j];
            }
        }
    }
    return sumElements;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}