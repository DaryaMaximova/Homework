// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int row = 2;
int col = 2;

int[,] Line = new int[row, col];
{
    for (int i = 0; i < Line.GetLength(0); i++)
    {
        for (int j = 0; j < Line.GetLength(1); j++)

        {
            Line[i, j] = new Random().Next(0, 10);
            Console.Write($"{Line[i, j]} ");
        }
    }
}


int k1 = Line[0, 0];
int k2 = Line[1, 0];
int b1 = Line[0, 1];
int b2 = Line[1, 1];

Console.WriteLine("");
Console.WriteLine($"k1= {k1} ");
Console.WriteLine($"k2= {k2} ");
Console.WriteLine($"b1= {b1} ");
Console.WriteLine($"b2= {b2} ");


if (k1 != k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine(" ");
    Console.WriteLine("Координаты точки пересечения прямых: " + $"{x}" + " , " + $"{y}");
    Console.WriteLine("");
}
else
{
    Console.WriteLine("Прямые не пересекаются");
};

Console.WriteLine();
