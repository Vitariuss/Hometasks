Console.Clear();

Console.WriteLine("Write your number");
int n = int.Parse(Console.ReadLine());
int m = 1;
if (n < 1)
{
    Console.WriteLine("Wrong number");
}
Console.WriteLine(NatNum(n, m));

int NatNum(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NatNum(n, m + 1)}, ");
    return m;
}

