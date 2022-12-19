Console.WriteLine(ForeverZero().Contains(0));

IEnumerable<int> ForeverZero()
{
    for (; ; ) yield return 0;
}
