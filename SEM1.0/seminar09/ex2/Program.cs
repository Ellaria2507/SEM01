// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("N");
int n = int.Parse(Console.ReadLine());
 Console.WriteLine(SumNumbers(m, n));
SumNumbers(m,n);
int SumNumbers(int m, int n)
    {
        if (m == n)
        {
            return m;
        }
        else
        {
            return m + SumNumbers(m + 1, n);
        }
       
    }