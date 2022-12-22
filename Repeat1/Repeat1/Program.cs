int[] a = Enumerable.Repeat(-1, 100).ToArray();
if (a.All(c => c == -1)) Console.WriteLine("配列の要素は全て-1です。");
