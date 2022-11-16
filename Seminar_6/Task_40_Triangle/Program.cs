// Задача 40: Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
System.Console.Write("Введите число 1 (в диапазоне от 0 до 100): ");
int number1;
while (!int.TryParse(Console.ReadLine(), out number1) || number1<1 || number1>100)
{
    System.Console.WriteLine("Введите число 1 (в диапазоне от 1 до 100): ");
}

System.Console.Write("Введите число 2 (в диапазоне от 0 до 100): ");
int number2;
while (!int.TryParse(Console.ReadLine(), out number2) || number2<1 || number2>100)
{
    System.Console.WriteLine("Введите число 2 (в диапазоне от 1 до 100): ");
}

System.Console.Write("Введите число 3 (в диапазоне от 0 до 100): ");
int number3;
while (!int.TryParse(Console.ReadLine(), out number3) || number3<1 || number3>100)
{
    System.Console.WriteLine("Введите число 3 (в диапазоне от 1 до 100: ");
}

CompareSidesOfTriangle(number1, number2, number3);

void CompareSidesOfTriangle(int n1, int n2, int n3)
{
    if (n1 + n2 >n3 && n2 + n3 >n1 && n1 + n3 >n2)
        System.Console.WriteLine("Такой треугольник существует!");

    else
    {
        System.Console.WriteLine("Такой треугольник не существует!");
    }
}