int[] a = { 1, 4, 2, 3, 6, 5 };
Console.WriteLine($"元データ{string.Join(',', a)}");
Console.WriteLine($"3より大きな値のみ{string.Join(',', a.Where(c => c > 3))}");
Console.WriteLine($"偶数番目のみ{string.Join(',', a.Where((c, i) => i % 2 == 1))}");
