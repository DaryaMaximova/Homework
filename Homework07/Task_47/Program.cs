// // Показать двумерный массив размером m×n заполненный вещественными числами
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] array = new double[3, 4];
Random random = new Random();
void FillArray(double[,] array)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            array[row, col] = random.NextDouble() * 100;
        }
    }
}

void PrintArray(double[,] array)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write($"{array[row, col]:f2}  ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);
