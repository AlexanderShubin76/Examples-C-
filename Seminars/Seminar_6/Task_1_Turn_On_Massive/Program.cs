// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте,
// а первый на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]

int[] array = {1, 2, 3, 4, 5, 6};
RevertArray(array);
PrintArray(array);
int[] copyOfArray = CopyRevertArray(array);
PrintArray(copyOfArray); 

int[] CopyRevertArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[array.Length-1-i]; 
        // copy[i] = array[^(i+1)];
    }
    return copy;
}

void RevertArray(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = temp;
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}