 //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Write("введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
if(a > b){
    Console.WriteLine("max = "+a);
}
else if(b > c){
    Console.WriteLine("max = "+b);
}
else Console.WriteLine("max = "+c);
