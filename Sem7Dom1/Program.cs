Console.Clear();
    FillArray();
    Console.Write(""); Console.ReadLine();

    void FillArray()
    {
        Console.WriteLine("Write the size of your array m x n: ");
        Console.Write("Write the number of lines" + "  " + "m = ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write the number of columns" + "  " + "n = ");
        int n = Convert.ToInt32(Console.ReadLine()); 

        double[,] array = new double[m, n];
        Random random = new Random();
        Console.WriteLine();
        Console.WriteLine("Here is your array!");
        Console.WriteLine();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = Math.Round((random.NextDouble() * 200 - 100), 2);
                Console.Write("{0, 10}", (array[i, j]).ToString("0.0"));
               
            }
        Console.WriteLine();
        }
    }
  