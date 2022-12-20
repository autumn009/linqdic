List<int> a = new List<int> { 1, 2, 3, 4 };

Console.WriteLine($"LINQのカウントメソッドで要素数: {a.Count()}");
Console.WriteLine($"Listクラスのプロパティで要素数: {a.Count}");

Console.WriteLine($"Countメソッドのみで2以上の要素数: {a.Count(c=>c >= 2)}");
Console.WriteLine($"WhereメソッドとCountメソッドで2以上の要素数: {a.Where(c => c >= 2).Count()}");
