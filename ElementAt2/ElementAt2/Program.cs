Console.WriteLine(GetOne().ElementAtOrDefault(10));

IEnumerable<int> GetOne()
{
    for (; ; ) yield return 1;
}
