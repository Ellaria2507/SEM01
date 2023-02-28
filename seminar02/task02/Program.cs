// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("number ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100){
    Console.WriteLine("нет 3 числа");
}
else{
    while (number > 999){
        number = number / 10;  
    }
    int b = number % 10;
    Console.WriteLine(b);
}
