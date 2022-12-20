Console.WriteLine($"{ZeroForever().Distinct()}");

IEnumerable<int> ZeroForever()
{
    for(; ; ) yield return 0;
}
