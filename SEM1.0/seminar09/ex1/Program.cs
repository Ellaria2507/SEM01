// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Enter number ");
int n = int.Parse(Console.ReadLine());
GetNumber(n);
void GetNumber(int n)
{
    if(n == 0)
    {
        return;
    }
    Console.Write(n + " ");
    GetNumber(n - 1);
}

