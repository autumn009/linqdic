int[] a = { 1, 2, 3 };
List<int> b = new List<int> { 1, 2, 3 };
int[] c = { 1, 2, 4 };
int[] d = { 1, 2, 3, 4 };
int[] e = { 1, 2, 3 };

Console.WriteLine($"aとbの比較結果: {a.SequenceEqual(b)}");
Console.WriteLine($"aとcの比較結果: {a.SequenceEqual(c)}");
Console.WriteLine($"aとdの比較結果: {a.SequenceEqual(d)}");
Console.WriteLine($"aとeの比較結果: {a.SequenceEqual(e)}");
