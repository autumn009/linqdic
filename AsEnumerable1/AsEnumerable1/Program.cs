var qParallel = Enumerable.Range(1, 20).AsParallel();
var qSerial = qParallel.AsEnumerable();
Console.Write("By Parallel: ");
foreach (var item in qParallel.Select(c => workAsync(c))) Console.Write($"{item} ");
Console.WriteLine();
Console.Write("By Serial: ");
foreach (var item in qSerial.Select(c => workAsync(c))) Console.Write($"{item} ");
Console.WriteLine();

static int workAsync(int x)
{
    Thread.Sleep(Random.Shared.Next(100));
    return x;
}