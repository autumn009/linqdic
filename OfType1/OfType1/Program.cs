object[] a = { 1, 2, 3, 4, "Hello", 5, 6, "Excellent!", "EOF" };
Console.WriteLine($"配列aの整数のみの合計は{a.OfType<int>().Sum()}です。");