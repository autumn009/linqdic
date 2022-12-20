for (int i = 0; i < 5; i++)
{
    var a = Enumerable.Range(0, i);
    Console.WriteLine($"{string.Join(',',a)}の最大値は{a.DefaultIfEmpty().Max()}");
}



