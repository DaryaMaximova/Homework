//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите два числа: ");
int Number = Convert.ToInt32(Console.ReadLine());
int Rank = Convert.ToInt32(Console.ReadLine());
double Method(double A, double b)

{
    double result = Convert.ToInt32(Math.Pow(A, b));
    return result;
}

double NumberInRank = Method(Number, Rank);
Console.WriteLine(NumberInRank);