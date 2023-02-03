Console.Clear();

Console.WriteLine("Write down your first number");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Write down your second number");
int num2 = int.Parse(Console.ReadLine());

if (num1 * num1 == num2 || num2 * num2 == num1)
{
    Console.WriteLine("Yes, one of these numbers is a square of another one");
}
else
{
    Console.WriteLine("No, neither of these numbers is a square of another one");
}