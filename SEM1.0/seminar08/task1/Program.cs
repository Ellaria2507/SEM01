﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
void GetArray() 
{ 
    int[,] array = new int[,] 
    { 
        { 1, 4, 7, 2 }, 
        { 5, 9, 2, 3 }, 
        { 8, 4, 2, 4 } 
    }; 
     
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            for (int k = j + 1; k < array.GetLength(1); k++) 
            { 
                if (array[i, j] > array[i, k]) 
                { 
                    int temp = array[i, j]; 
                    array[i, j] = array[i, k]; 
                    array[i, k] = temp; 
                } 
            } 
        } 
    } 
    PrintArray(array);
} 
 
void PrintArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write(array[i, j] + " "); 
        } 
        Console.WriteLine(); 
    } 
} 
 
GetArray();
