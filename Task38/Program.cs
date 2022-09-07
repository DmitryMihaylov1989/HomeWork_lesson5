// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] RealNumbers = new double[5];
  for (int i = 0; i < RealNumbers.Length; i++ )
  {
    RealNumbers[i] = new Random().Next(0, 100);
    Console.Write(RealNumbers[i] + " ");
  }

double max = RealNumbers[0];
double min = RealNumbers[0];

  for (int i = 1; i < RealNumbers.Length; i++)
  {
    if (max < RealNumbers[i])
    {
      max = RealNumbers[i];
    }
        if (min > RealNumbers[i])
    {
      min = RealNumbers[i];
    }
  }

  double diff = max - min;

  Console.WriteLine($"\nразница между между максимальным и минимальным элементами: {diff}");

