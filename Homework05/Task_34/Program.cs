//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Введите размер массива : ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
int count = 0;
int EvenNumbers(int N, int[] arr, int count)
{
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.Write("{0} ", arr[i]);
    }
    Console.WriteLine(" ");

    foreach (int element in arr)
    {
        if (element % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Количество четных элементов {0}", count);
    return count;
}
EvenNumbers(N, arr, count);
