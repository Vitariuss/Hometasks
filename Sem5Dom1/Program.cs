Console.Clear();

Console.WriteLine("How big should your array be?");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Here is your array: ");
PrintArray(numbers);
int even = 0;

for (int num = 0; num < numbers.Length; num++)
if (numbers[num] % 2 == 0)
even++;

Console.WriteLine($"There are {numbers.Length} numbers in your array and only {even} of them are even ones");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}