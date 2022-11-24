// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Пример. Есть набор данных:
// { 1, 9, 9, 0, 2, 8, 0, 9 }

int[,] FindRepeatElementsInArray(int[,] array)
{
  
   int rows = array.GetLength(0);
   int cols = array.GetLength(1);
   int element = array[0,0];
   int count = 0;
    for (int k = 0; k < rows; k++)
    {
        for (int i = 0; i < cols; i++)
        {
            element = array[k,i];
            for (int m = 0; m < rows; m++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if(array[i,j] == element)
                    {
                        count++;
                    }       
                }
            }
    }
    System.Console.WriteLine($"{array[i,j]} встречается {count} раз ");
    count = 0;
    }
    return array;
}
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
int[,] array = new int[,]{
                        {1,5,7,2},
                        {5,9,2,3},
                        {8,4,2,4},
                        {5,2,6,7}};
System.Console.WriteLine();
FindRepeatElementsInArray(array);
PrintArray(array);