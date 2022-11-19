// 17. Напишите программу, которая
int GetNumberofPlane(int x, int y)
{
    if(x == 0 || y == 0) return -1;

    if (x > 0 && y >0) return 1;
    
    if (x <0 && y > 0)return 2;
    
    if (x <0 && y < 0)return 3;
    
    if (x > 0 && y < 0) return 4;

    else return -1;
}

int numberOfPlane = GetNumberofPlane(-19,20);
System.Console.WriteLine($"Номер плоскости: {numberOfPlane}");