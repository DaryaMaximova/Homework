// Показать двумерный массив размером m×n заполненный вещественными числами

double[,] array = new double[2, 2];
Random random = new Random();
void FillArray(double[,] array)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            array[row, col] = random.NextDouble() * 100;
            //Console.WriteLine(" "+ array[row,col]);
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
            //Console.Write(string.Format("{0:f2} ",array[row, col]));
            Console.Write($"{array[row, col]:f2} ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);