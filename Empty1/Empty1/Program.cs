var a = Enumerable.Empty<int>();
for (int i = 1; i <= 256; i *= 2) a = a.Append(i);
Console.WriteLine($"{string.Join(',',a)}");
