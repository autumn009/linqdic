Console.WriteLine($"シーケンスのカウントは{GetLongEnum().LongCount()}");
// 以下の行は例外を起こし実行できない
// Console.WriteLine($"シーケンスのカウントは{GetLongEnum().Count()}");

IEnumerable<long> GetLongEnum()
{
	for (long i = 0L; i < (long)int.MaxValue+1L; i++)
	{
		yield return i;
	}
}