//Напишите программу, которая выводит случайное трехзачное число и удаляет вторую цифру этого числа. 
//456->46
//782->72
//918->98


int a = new Random().Next(100, 999);
Console.WriteLine(a);
int first = (a/100);
Console.WriteLine(first);
int last = (a/1);
Console.WriteLine(last);

Console.Write ($"{first}{last}"\n");

