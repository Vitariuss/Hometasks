Console.Clear();

Console.Write("Write b1 - ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Write k1 - ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Write b2 - ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Write k2 - ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
 if (k1 == k2 && b1 == b2)
 {
    Console.WriteLine ("The lines are the same");
 }
 else if (k1 == k2)
 {
    Console.WriteLine ("The lines are parallel");
 }
 else 
 {
    Console.WriteLine ($"Cross will be at ({x};{y})");
 }