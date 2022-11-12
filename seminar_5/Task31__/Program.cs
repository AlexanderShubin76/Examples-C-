int length = 6;

int[] massive = GetArray(length);
FillArray(massive);
PrintArray(massive);
int sumPositive = SumOfSignNumbers(massive, true);
int sumNegative = SumOfSignNumbers(massive, false);

System.Console.WriteLine($"{sumPositive}, {sumNegative}");

int SumOfSignNumbers(int[] array, bool isPositive)
{
    int sum = 0;
    foreach (int item in array)
    {
        if (isPositive && item > 0)
            {
            sum += item;
            }
        else if(!isPositive && item < 0)
        {
            sum += item;
        }
    }
    
    return sum;
}

void FillArray(int[] array, int minValue = -9, int maxValue = 9)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
}
int [] GetArray(int length, int minValue = -9, int maxValue = 9)
{
    int[] array = new int[length];
    
    FillArray(array, minValue, maxValue+1);
    return array;
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine();
}