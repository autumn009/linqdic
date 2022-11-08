int[] a = { 1, 2, 3 };
IEnumerable<int> b = a;
IEnumerable<int> c = a.ToArray();
Console.WriteLine($"b.Sum()={b.Sum()}");
Console.WriteLine($"c.Sum()={c.Sum()}");
a[0] = 2;
Console.WriteLine($"b.Sum()={b.Sum()}");
Console.WriteLine($"c.Sum()={c.Sum()}");
