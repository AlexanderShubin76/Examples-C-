// Задача 30:
// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void Makemassive(int lengthArray)
{
    int [] array = new int [lengthArray];
    
    for (int i = 0; i < lengthArray; i++)
    {
       array [i] = new Random().Next(0,2);
    }
    System.Console.WriteLine(string.Join(",", array));
} 
int number;
string text = "Введите значение 1 для запуска программы "
+ "или любое другое значение для остановки программы.";

System.Console.WriteLine(text);
while (int.TryParse(Console.ReadLine(), out number) && number==1)
{
    Console.Write("Введите размер массива: ");
    int length;
    while (!int.TryParse(Console.ReadLine(), out length) || length < 1)
    {
        System.Console.WriteLine("Введите цифру больше 0");
    }
    Makemassive(length);
    System.Console.WriteLine(text);
}