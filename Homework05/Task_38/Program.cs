//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива:");
int N = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[N];
Random random = new Random();
int i = 0;
double DifferenceMaxAndMinElements(int N, double [] arr)
{
    for (i = 0; i < N; i++)
    {
        arr[i] = random.NextDouble()*100;
        Console.WriteLine(" "+ arr[i]);
    }

    double min = arr[0];
    double max = arr[0];

    for (i = 0; i < N; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        else if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    Console.WriteLine("\nМинимальный элемент: " + min);
    Console.WriteLine("Максимальный элемент: " + max);
    double result = max - min;
    Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + result);
    return i;
}
DifferenceMaxAndMinElements(N, arr);
