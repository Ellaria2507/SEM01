// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] NewArray(){
int[] array = new int[4];
    for(int i = 0; i < array.Length; i++){
      array[i] = Random.Shared.Next(10, 100);
     
  }
  Console.WriteLine($"[{string.Join(",",array)}]");
  return array;
  }
  int MaxMinArray(int[] array){
    int result = 0;
    int max = array[0];
    int min =array[0];
    for(int i = 0; i < array.Length; i++){
        if(max < array[i]){
            max = array[i];
        }
        else if (min > array[i])
        {
            min = array[i];
        }
    result = max - min;
    }
 return result;
  }
  int[]rasn = NewArray();
 int SUM = MaxMinArray (rasn);
Console.WriteLine(string.Join(",", SUM));


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// int[] NewArray(){
//  int[] array = new int[4];
//    for(int i = 0; i < array.Length; i++){
//      array[i] = Random.Shared.Next(-10, 10);
     
//  }
//  Console.WriteLine($"[{string.Join(",",array)}]");
//  return array;
//  }
//  int ArraySum(int[] array){
//  int sum = 0;
//  for(int i = 0; i < array.Length; i++){
//  if(i % 2 != 0){
//     sum += array[i];
//  }
//  }
//  return sum;
//  }
// int[] result = NewArray();
// int SUM = ArraySum (result);
// Console.WriteLine(string.Join(",", SUM));

//  34 Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// int[] NewArray(){
// int[] array = new int[4];
//     for(int i = 0; i < array.Length; i++){
//     array[i] = Random.Shared.Next(100, 1000);
    
// }
// Console.WriteLine(string.Join(",", array));
// return array;

// }
// int DigitsNumber(int[] array){
//     int number = 0;
//     for(int i = 0; i < array.Length; i++){
//         if (array[i] % 2 == 0){
//             number += 1;
//         }
//     }
//     return number;
// }
//  int[] evenNumber = NewArray();
// int SUM = DigitsNumber(evenNumber);
// Console.WriteLine(string.Join(",", SUM));
