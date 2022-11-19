// Задача 46: Задайте двумерный массив размером mxn, заполн 
// случайными числами
int[,] array = GetArrayRandom(3,4);
PrintArray(array);

int[,] GetArrayRandom(int rows, int cols, int minValue = 0, int maxValue = 100)
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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}