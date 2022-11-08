sub(new int[] { 1, 2, 3 });
sub(new int[] { 1, -2, 3 });
sub(new int[] { 1, -2, -3 });

void sub(int[] array)
{
	Console.Write($"【{string.Join(',', array)}は全て正数】");
	if (array.All(c => c >= 0))
		Console.WriteLine("です。");
	else
		Console.WriteLine("ではありません。");
}


