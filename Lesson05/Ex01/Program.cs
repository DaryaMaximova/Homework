// Показать двумерный массив размером m×n заполненный целыми числами

int[,] array = new int[m, n];
void FillArray(int[,] array)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
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
            Console.Write($"{array[row, col], 3}");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);
