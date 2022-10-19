int [] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};
int n = array.Length;
int find = 18;
for (int index = 0; index < n; index++)
{
    if (array[index] == find) System.Console.WriteLine(index);
    break;
}