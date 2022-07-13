﻿/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int [] GetArray(int dimension)
{
int[] arr = new int[dimension];
Random randomizer = new Random();

for(int i=0; i < arr.Length; i++)
{
   arr[i] = randomizer.Next(100, 1000);
}

return arr;
}

void PrintArray(int [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
   Console.Write($"{arr[i]} ");
}
}


int Amount(int [] arr)
{
   int count = 0;
for (int i = 0; i < arr.Length; i++)
{
   if (arr[i] % 2 == 0)
   {
      count++;
   } 
}
return count;
}



Console.WriteLine("Введите размерность массива:");
int dimension = int.Parse(Console.ReadLine());

int [] arr = GetArray(dimension);
PrintArray(arr);


Console.WriteLine();

int amount = Amount(arr);
Console.WriteLine($"Колличество четных чисел в массиве = {amount}");