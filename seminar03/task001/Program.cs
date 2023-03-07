// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int palid = 0, num = number;
while (number > 0){
    palid = palid * 10 + number % 10;
    number = number / 10;
}
// for (number > 0; palid = palid *10 + number % 10; number = number / 10){
    if(num == palid){
     Console.WriteLine("yes");
    }
    else Console.WriteLine("no");


