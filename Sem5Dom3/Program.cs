Console.Clear();

Console.WriteLine("Input array size");
int size = int.Parse(Console.ReadLine());
double[] numbers = new double[size];
ArrayRandomNumbers(numbers);
Console.WriteLine("Here is your array: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int num = 0; num < numbers.Length; num++)
{
    if (numbers[num] > max)
        {
            max = numbers[num];
        }
    if (numbers[num] < min)
        {
            min = numbers[num];
        }
}

Console.WriteLine($"There are {numbers.Length} numbers. Max is {max} and min is {min}");
Console.WriteLine($"The difference between max and min is {max - min}");

void ArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}