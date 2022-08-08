//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a = 5;
int b = 7;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.Write("max = ");
Console.WriteLine(max);

int a2 = 2;
int b2 = 10;
int max2 = a2;
if (a2 > max2) max2 = a2;
if (b2 > max2) max2 = b2;
Console.Write("max = ");
Console.WriteLine(max2);

int a3 = -9;
int b3 = -3;
int max3 = a3;
if (a3 > max3) max3 = a3;
if (b3 > max3) max3 = b3;
Console.Write("max = ");
Console.WriteLine(max3);



