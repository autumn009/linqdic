using System.Linq;

int[] a = { 2, 3, 1 };
Console.WriteLine($"オリジナルデータ: {string.Join(',', a)}");
Console.WriteLine($"OrderByメソッド: {string.Join(',', a.OrderBy(c=>c))}");


