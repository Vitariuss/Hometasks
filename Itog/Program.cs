﻿Console.Clear();

Console.WriteLine("Введите слова или числа через пробел");
string str = Console.ReadLine();
string[] array = str.Split(' ').Distinct().ToArray();

var array2 = array.Where(x=>x.Length < 4).ToArray();

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Your new array is - ");
PrintArray(array2);