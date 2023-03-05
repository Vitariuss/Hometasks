Console.Clear();

Console.WriteLine("Write your first number (less one)");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Write your second number (bigger one)");
int m = int.Parse(Console.ReadLine());


int CountSum(int n, int m)
{
    if (n == m)
        return n;
    else
        return n + CountSum(n + 1, m);
}


Console.WriteLine($"Sum of the numbers from {n} to {m} is {CountSum(n, m)}");