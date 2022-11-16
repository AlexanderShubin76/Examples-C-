// Задача 42: Напишите программу, которая
// будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
System.Console.WriteLine("Введите число (в диапазоне от 1 до 100): ");
int number;
while (!int.TryParse(Console.ReadLine(), out number) || number > 100 || number < 1)
{
    System.Console.WriteLine("Введите число в диапазоне от 1 до 100: ");
}
ConvertDigit(number);
void ConvertDigit(int n)
{
    string emp = string.Empty;
    for (int i = 0; n!=0; i++)
    {
        int k = n%2;
        n /=2;
        emp += k.ToString();
    }
    char[] arr = new char[emp.Length];
    for (int j = 0; j < emp.Length; j++)
    {
        arr[j] = emp[^(j+1)];
    }
    System.Console.WriteLine(string.Join("", arr));
}