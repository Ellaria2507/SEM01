﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
int[,] matrix1 = new int[4, 4]
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 },
    { 5, 2, 6, 7 }
};

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        Console.Write(matrix1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] matrix2 = new int[4, 4]
{
    { 1, 5, 8, 5 },
    { 4, 9, 4, 2 },
    { 7, 2, 2, 6 },
    { 2, 3, 4, 7 }
};
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        Console.Write(matrix2[i, j] + " ");
    }
    Console.WriteLine();
}

void Main()
{
    int[,] newMatrix = new int[4, 4];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
           newMatrix[i,j] += matrix1[i, j] * matrix2[i, j];
        }
    }
     for (int i = 0; i < newMatrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < newMatrix.GetLength(1); j++) 
        { 
            Console.Write(newMatrix[i, j] + " "); 
        } 
        Console.WriteLine(); 
    }
}
Main();