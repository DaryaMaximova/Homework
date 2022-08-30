//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArray(int row, int col)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Multiplication(int[,] numbers1, int[,] numbers2)
{
    if (numbers1.GetLength(1) != numbers2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] multiply = new int[numbers1.GetLength(0), numbers2.GetLength(1)];
    for (int i = 0; i < numbers1.GetLength(0); i++)
    {
        for (int j = 0; j < numbers2.GetLength(1); j++)
        {
            for (int k = 0; k < numbers2.GetLength(0); k++)
            {
                multiply[i, j] += numbers1[i, k] * numbers2[k, j];

            }

        }
    }
    return multiply;


}

void PrintMultiplyArray(int[,] multiply)
{
    for (int i = 0; i < multiply.GetLength(0); i++)
    {
        for (int j = 0; j < multiply.GetLength(1); j++)
        {
            Console.Write($"{multiply[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] numbers1 = CreateArray(2, 2);
Console.WriteLine();
int[,] numbers2 = CreateArray(2, 2);
PrintArray(numbers1);
Console.WriteLine();
PrintArray(numbers2);
Console.WriteLine();
Multiplication(numbers1, numbers2);
int[,] multiply = Multiplication(numbers1, numbers2);
PrintMultiplyArray(multiply);













