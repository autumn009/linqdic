int[] a = { 1, 2 };
int[] b = { 3, 4, 5 };
var r = a.Zip(b);
foreach (var item in r) Console.Write($"{item.First}{item.Second}");
