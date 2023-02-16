Console.Clear();

Console.WriteLine($"\n Write the size of your array:");
int m = InputNumbers("Input the number of lines : ");
int n = InputNumbers("Input the number of columns: ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSum = 0;
int sum = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int aSum = SumLine(array, i);
  if (sum > aSum)
  {
    sum = aSum;
    minSum = i;
  }
}

int SumLine(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int q = int.Parse(Console.ReadLine());
  return q;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(100);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

Console.WriteLine($"\n The least line is the line #{minSum+1} with the sum of {sum}");
