// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса нечётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] array = GetArrayRandom(3,4);
PrintArray(array);
int[,] array1 = FillArray(array);
System.Console.WriteLine();
PrintArray(array1);

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

int[,] FillArray(int[,] massive)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i%2!=0 && j%2!=0)
            {
                massive[i,j] = (int) Math.Pow(massive[i,j], 2);
            }
        }
    }
    return massive;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} 1\t ");
        }
        System.Console.WriteLine();
    }
}