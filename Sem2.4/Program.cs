Console.Clear();

Console.WriteLine("Write down your  number");
int num = int.Parse(Console.ReadLine());


if ( num % 7 == 0 && num % 23 == 0)
{
   Console.WriteLine($"Yes, you can divide {num} by 7 and 23! "); 
}
else
{
    Console.WriteLine($"No, you can't divide {num} by 7 and 23");
}