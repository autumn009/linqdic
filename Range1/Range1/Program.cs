Console.WriteLine("for文を使った古いやり方");
for (int i = 0; i < 10; i++)
{
    if (i != 0) Console.Write(",");
    Console.Write($"{i}");
}
Console.WriteLine();

Console.WriteLine("Rangeメソッドを使ったやり方");
Console.WriteLine($"{string.Join(',', Enumerable.Range(0, 10))}");
