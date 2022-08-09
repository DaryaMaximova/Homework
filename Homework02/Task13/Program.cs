// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int a = 645;
Console.WriteLine(a);
if (a > 99) Console.WriteLine(a % 10);
else Console.WriteLine("третьей цифры нет");

int b = 78;
Console.WriteLine(b);
if (b > 99) Console.WriteLine(b % 10);
else Console.WriteLine("третьей цифры нет");

int c = 32679;
if (c > 99) Console.WriteLine(c / 1000);
else Console.WriteLine("третьей цифры нет");



