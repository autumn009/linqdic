Console.WriteLine($"シーケンスのカウントは{GetLongEnum().LongCount()}");

IEnumerable<long> GetLongEnum()
{
	for (long i = 0L; i < (long)int.MaxValue+1L; i++)
	{
		yield return i;
	}
}