// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

void PrintNumbers(int m, int n)
		{
			int s = m;
			int e = n;
			if(m > n)
			{
				s = n;
				e = m;
			}
			for(int i = s; i <= e; i++)
			{
				Console.Write($"{i} ");
			}
		}
		PrintNumbers(4, 8);
		