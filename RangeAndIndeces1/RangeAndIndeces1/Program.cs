int[] a = { 1, 2, 3, 4 };
Console.WriteLine(a[^1]);
Console.WriteLine(a[^2]);
int[] b = a[1..3];
Console.WriteLine(string.Join(',',b));
string s = "Hello"[1..3];
Console.WriteLine(s);