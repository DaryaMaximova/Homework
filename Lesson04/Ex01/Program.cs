// 1. Напишите метод, которая возвращает массив из N элементов, 
// заполненный нулями и единицами в случайном порядке.
//N = 3 => [1, 0, 0]
//N = 8 => [1,0,1,1,0,1,0,0]

//int [] array = {1, 0, 0};
//Console.WriteLine(array.Length);


void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

int[] CreateBinaryNumber(int count)
{
    int[] bin = new int[count];

    for (int i = 0; i < count; i++)
    {
        bin[i] = new Random().Next(0, 2);
    }

    return bin;
}
Console.WriteLine("Vvedite chislo elementov N: ");

int n = Convert.ToInt32(Console.ReadLine());


int[] binary = CreateBinaryNumber(n);
Print(binary);






