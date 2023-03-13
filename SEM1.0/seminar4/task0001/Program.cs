// void int Method3();
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// int ReadIntNumber(string messageToUser)
// {
//     Console.WriteLine(messageToUser);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int SumFrom1ToA(int a)
// {
//     int sum = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }
// int number = ReadIntNumber("click A ");
// int result = SumFrom1ToA(number);
// Console.WriteLine($"summa from 1 to {number} = {result}");



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int EnterNumber(){
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }
// int SumNumber(int a){ 123
//     int result = 0;
//     int sum = 0;
//     while(a > 0){
//     sum = a % 10;
//     result = result + sum; 
//     a /= 10;
//     }
//     return result;
// }

// int SUM = EnterNumber();
// int summ = SumNumber(SUM);
// Console.WriteLine(summ);

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3,5 = 243
// Console.Clear();
// Console.WriteLine("number 1");
// Console.WriteLine("number 2");
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= b ; i++){
//     result *= a;
    
//     Console.WriteLine($"{a}  в степень {b} = {result}");
// }

// int[] array = new int[] {1 , 4 , 6 , 7 , 8, 9, 24, 65};
//     void Array1(int[] arrayA){
    
//     for(int i = 0; i < arrayA.Length; i++){
//         Console.WriteLine(arrayA[i]);
//     }
// }
// Array1(array);