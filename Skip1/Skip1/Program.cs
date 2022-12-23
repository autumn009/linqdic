int[] a = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
Console.WriteLine($"元のシーケンス: {string.Join(',', a)}");
Console.WriteLine($"Skip(4): {string.Join(',', a.Skip(4))}");
Console.WriteLine($"SkipLast(4): {string.Join(',', a.SkipLast(4))}");
Console.WriteLine($"SkipWhile(c=>c<5): {string.Join(',', a.SkipWhile(c => c < 5))}");
