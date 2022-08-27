// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел : ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
int count = 0;
int PositiveNumbers(int N, int[] arr, int count)
{
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(-1000, 1000);
        Console.Write("{0} ", arr[i]);
    }
    Console.WriteLine(" ");

    foreach (int element in arr)
    {
        if (element > 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Количество положительных чисел {0}", count);
    return count;
}
PositiveNumbers(N, arr, count);

