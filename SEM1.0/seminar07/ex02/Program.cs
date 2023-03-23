// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
void ArrayElements(int[,] array) 
{ 
    Console.Write("Введите строку: "); 
    int row = int.Parse(Console.ReadLine()); 
    Console.Write("Введите столбец: "); 
    int column = int.Parse(Console.ReadLine());

    if (row >= 0 && row < array.GetLength(0) && 
        column >= 0 && column < array.GetLength(1)) 
    { 
        Console.WriteLine($"Элемент [{row}, {column}] = {array[row, column]}"); 
    } 
    else 
    { 
        Console.WriteLine("Такого элемента нет"); 
    } 
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
 void Main() 
{ 
    int[,] array = new int[,] {{1, 4, 7, 2},{5, 9, 2, 3},{8, 4, 2, 4}}; 
ArrayElements(array);
PrintArray(array);
 }

Main();