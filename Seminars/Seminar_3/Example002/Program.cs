// Задача 18: 
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
string ShowDiapason(int Plane)
{
if (Plane == 0) return "Недопустимое значение";
else if (Plane == 1) return "x>0, y>0";
else if (Plane == 2) return "x<0, y>0";
else if (Plane == 3) return "x<0, y<0";
else Plane == 4 return "x>0, y<0";
}
System.Console.WriteLine("Введите значение: ");
int numberPlane = int.TryParse(Console.ReadLine()!);
System.Console.WriteLine(ShowDiapason(numberPlane));