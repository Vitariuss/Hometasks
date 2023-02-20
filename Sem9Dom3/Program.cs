Console.Clear();

Console.WriteLine("You need to input n and m numbers in Ackermann function (n, m)");
Console.WriteLine("Write the n number");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Write the m number");
int m = int.Parse(Console.ReadLine());

int Ack(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Ack(n - 1, 1);
    else
        return Ack(n - 1, Ack(n, m - 1));
}
 
Console.WriteLine($"The result of Ackerman function ({n}, {m}) is {Ack(n, m)}");
Console.ReadKey();
