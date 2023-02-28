// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("number ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = { 1, 2, 3, 4, 5, 6, 7 };
array[0] = 1;
if (number <= array[4]){
    Console.WriteLine("no");
}
else if (number > array[6]){
    Console.WriteLine("try again");
}    
else Console.WriteLine("yes");
