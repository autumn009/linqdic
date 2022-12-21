string[] a = { "Alice", "Betty" };
Console.WriteLine(string.Join(',', a.GroupBy(c => c.Contains("A")).Select(c => $"Key={c.Key} Value={string.Join(',', c)}")));
