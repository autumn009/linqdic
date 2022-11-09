IEnumerable<int> a = Enumerable.Range(0, 10);
IEnumerable<int[]> x = a.Chunk(4);
foreach (var item in x)
{
	foreach (var item2 in item) Console.Write($"{item2} ");
	Console.WriteLine();
}
