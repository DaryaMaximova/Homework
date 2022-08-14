// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Задайте координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());


double f (double A, double B, double C);
{
    double A = (x1-x2); double B = (y1-y2); double C = (z1-z2);
    double result = Math.Sqrt(A*A)+(B*B)+(C*C);
    return result;
}


//double f = (Math.Sqrt((y1-y2)*(y1-y2) + (x1-x2)*(x1-x2) + (z1-z2) * (z1-z2)));
//Console.WriteLine(f);
//f(result);
Console.WriteLine(f);


//string Method4(int count, string c)
// {
//  int i = 0;
// string result = String.Empty;
// while (i < count)
//  {
//     result = result + c;
//        i++;
//  }
//    return result;
// }
//string res=Method4(10, "z");
//Console.WriteLine(res);