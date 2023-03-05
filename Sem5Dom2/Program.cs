Console.Clear();

Console.WriteLine("Input array size");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
ArrayRandomNumbers(numbers);
Console.WriteLine("Here is your array: ");
PrintArray(numbers);
int sum = 0;

for (int odd = 0; odd < numbers.Length; odd = odd + 2)
    sum = sum + numbers[odd];

    Console.WriteLine($"There are {numbers.Length} numbers, odd elements sum is = {sum}");

void ArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(-100,100);
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