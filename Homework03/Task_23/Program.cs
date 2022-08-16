/* Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

double Method (double A, double b)
{
    double result = Convert.ToInt32(Math.Pow(A, b));
    return result;
}

int rank = 3;
double m = 1;
for (int i = 1; i <= N; i++)
{
    m = Method (i, rank);
    Console.Write(" " + m);
}
