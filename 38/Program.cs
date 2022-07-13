/*
 Задайте массив вещественных чисел. 
 Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] arr = new double[6];
  for (int i = 0; i < arr.Length; i++ )
  {
    arr[i] = new Random().NextDouble()*5;
    Console.Write($"{arr[i]:F2} ");
  }

double max = arr[0];
double min = arr[0];

  for (int i = 1; i < arr.Length; i++)
  {
    if (max < arr[i])
    {
      max = arr[i];
    }
        if (min > arr[i])
    {
      min = arr[i];
    }
  }

  double result = max - min;

Console.WriteLine();
Console.WriteLine($"Разница между между максимальным и минимальным элементами: {result:F2}");
  

