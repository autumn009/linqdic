int[] a = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
Console.WriteLine($"元のシーケンス: {string.Join(',', a)}");
Console.WriteLine($"Take(4): {string.Join(',', a.Take(4))}");
Console.WriteLine($"Take(5..7): {string.Join(',', a.Take(5..7))}");
Console.WriteLine($"TakeLast(4): {string.Join(',', a.TakeLast(4))}");
Console.WriteLine($"TakeWhile(c=>c<5): {string.Join(',', a.TakeWhile(c => c < 5))}");
