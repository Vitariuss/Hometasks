Console.Clear();

Console.WriteLine("Введите слова или числа через пробел");
string str = Console.ReadLine();
string[] array = str.Split(' ').Distinct().ToArray();

var array2 = array.Where(x=>x.Length < 4).ToArray();

