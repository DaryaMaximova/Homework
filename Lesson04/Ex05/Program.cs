// See https://aka.ms/new-console-template for more information

void Log(object o)
{
  File.AppendAllText("log.csv", $"{DateTime.Now};{o}\n");
}

int GetValue(string text)
{
  Log("вызван метод GetValue");

  int n = 0;

  while (!(n >= 10000 && n <= 99999))
  {
    Console.Write(text);
    string data = Console.ReadLine();
    Log(data);
    n = Convert.ToInt32(data);
  }
  Log("метод GetValue окончил работу");
  return n;
}

bool IsPolindrom(int value)
{
  Log("вызван метод IsPolindrom");

  int t = 0;
  int tValue = value;
  while (value != 0)
  {
    t = t * 10 + value % 10;
    value /= 10;
  }
  bool result = tValue == t;
  Log(result);
  Log("метод IsPolindrom окончил работу");

  return result;
}

void Main()
{
  Log("вызван метод main");
  int k = GetValue("Введите число из пяти цифр: ");
  Console.WriteLine($"k: {k}");
  Console.WriteLine($"IsPolindrom({k}): {IsPolindrom(k)}");
  Log("метод main окончил работу");
}

Main();



..sum = sum + Convert.ToInt32(c.ToString());
// char.GetNumericValue - символ превратить в число 

