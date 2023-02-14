Console.Clear();

Console.WriteLine("Write the number of lines");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write the number of columns");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        average = (average + numbers[i, j]);
    }
    average = average / n;

    decimal round = decimal.Round(Convert.ToDecimal(average), 3);
    Console.Write(round + "|");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

