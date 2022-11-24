﻿int row = 15;
int[,] triangle = new int[row, row];
const int cellWidth = 5;
PrintTriangle(FillTriangle(triangle));

int[,] FillTriangle(int[,] triangle)
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = 
            triangle[i-1, j-1] +triangle[i - 1, j];

        }
    }
    return triangle;
}

void PrintTriangle(int[,] triangle)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if(triangle[i,j] != 0)
            System.Console.Write($"{triangle[i,j],cellWidth} ");
        }
        System.Console.WriteLine();
    }
    
}