// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Clear();
// Console.Write("введите количество элементов ");
// int elements = Convert.ToInt32(Console.ReadLine());
// int[] NewArray(){
// int[] array = new int[elements];
//     for(int i = 0; i < array.Length; i++){
//         Console.Write("введите элемент массива {i} =  ");
//         array[i]= Convert.ToInt32(Console.ReadLine());
// }
// return array;
// }
// int SumNumber(int[] array){ 
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++){
        
//         if(array[i] > 0){
//             sum++;
//         }
//     }
//     return sum;
// }

int[] SUM = NewArray();
int summ = SumNumber(SUM);
Console.WriteLine(summ);



Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
