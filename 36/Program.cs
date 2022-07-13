/*
 Задайте одномерный массив, заполненный случайными числами.
  Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int [] GetArray(int dimension)
{
int[] arr = new int[dimension];
Random randomizer = new Random();

for(int i=0; i < arr.Length; i++)
{
   arr[i] = randomizer.Next(30);
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


int Sum(int [] arr)
{
   int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
   if (i % 2 == 0)
   {
      sum = sum + arr[i];
   } 
}
return sum;
}


Console.WriteLine("Введите размерность массива:");
int dimension = int.Parse(Console.ReadLine());

int [] arr = GetArray(dimension);
PrintArray(arr);


Console.WriteLine();

int sum = Sum (arr);
Console.WriteLine($"Сумма чисел на нечетных позициях в массиве = {sum}");