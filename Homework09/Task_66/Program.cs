// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


		int Sum (int m, int n)
		{
			int s = m;
			int e = n;
            int result = (e + s)*(e - s + 1)/2;
			if(m > n)
			{
				s = n;
				e = m;
                
			}
			return result;
		}
		
        Sum(4,8);
		Console.WriteLine(Sum(4, 8));
