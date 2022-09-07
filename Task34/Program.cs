// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = 5;
int[] arr = new int[size];
ArrayNumbers(arr);
PrintArray(arr);
int count = 0;


for (int a = 0; a < arr.Length; a++)
if (arr[a] % 2 == 0)
count++;

void ArrayNumbers(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
}


void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
Console.WriteLine();}
Console.WriteLine($"в этом массиве {arr.Length} чисел, {count} из них - чётные");