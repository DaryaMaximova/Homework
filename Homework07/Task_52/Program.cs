// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[2, 2];
void FillArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            array[row, col] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write($"{array[row, col],6}");
        }
        Console.WriteLine();
    }
}


void Average(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int srAr = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            srAr += array[i, j];
        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {(float)srAr /array.GetLength(1)}");
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
Average(array);

