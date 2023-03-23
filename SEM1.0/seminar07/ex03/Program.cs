// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 
int[,] array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
double[] avrg = new double[array.GetLength(1)];

for (int i = 0; i < array.GetLength(1); i++)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum += array[j, i];
    }
    avrg[i] = sum / array.GetLength(0);
}

Console.WriteLine(String.Join("; ", avrg));