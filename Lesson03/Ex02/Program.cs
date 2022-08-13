// Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


//int x = 1;
//int y = 1;

int x = new Random().Next(-1000, 1000);
int y = new Random().Next(-1000, 1000);

Console.WriteLine(x);
Console.WriteLine(y);


if (x > 0 & y > 0)
{
    Console.WriteLine("первая четверть");
}
if (x < 0 & y > 0)
{
    Console.WriteLine("вторая четверть");
}
if (x < 0 & y < 0)
{
    Console.WriteLine("третья четверть");
}
if (x > 0 & y < 0)
{
    Console.WriteLine("четвертая четверть");
}
if (x == 0 & y == 0)
{
    Console.WriteLine("начало координат");
}