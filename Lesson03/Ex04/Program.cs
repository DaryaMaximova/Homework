// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
//между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Задайте координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());


//int x1 = 3;
//int x2 = 2;
//int y1 = 6;
//int y2 = 1;
//int x1 = 7;
//int x2 = 1;
//int y1 = -5;
//int y2 = -1;

double f = (Math.Sqrt((y1-y2)*(y1-y2) + (x1-x2)*(x1-x2)));
Console.WriteLine(f);