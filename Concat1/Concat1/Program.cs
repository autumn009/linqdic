var a = Enumerable.Repeat("A", 5);
var b = Enumerable.Repeat("B", 5);
var c = a.Concat(b);
foreach (var item in c) Console.Write(item);
Console.WriteLine();


