Console.Clear();

Console.WriteLine($"\n Write the size of your array:");
int m = InputNumbers("Input m: ");
int n = InputNumbers("Input n: ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

Console.WriteLine($"\nYour sorted array: ");
OrderArrayLines(array);
WriteArray(array);

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int t = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = t;
        }
      }
    }
  }
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
