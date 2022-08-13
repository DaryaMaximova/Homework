// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Vvedite nomer chetverti");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1)
{
    Console.WriteLine("x> 0 && y > 0");
}
if (n == 2)
{
    Console.WriteLine("x<0 && y > 0");
}
if (n == 3)
{
    Console.WriteLine("x<0 && y < 0");
}
if (n == 4)
{
    Console.WriteLine("x> 0 && y < 0");
}
