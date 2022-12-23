var a = Enumerable.Range(1, 5);
sub(a, nameof(a));
var a2 = Enumerable.Range(1, 5).Skip(1);
sub(a2, nameof(a2));
var a3 = Enumerable.Range(1, 5).SkipWhile(c=>c>0);
sub(a3, nameof(a3));
int[] b = { 1, 2, 3, 4, 5 };
sub(b, nameof(b));
var c = b.ToList();
sub(c, nameof(c));
sub(myEnum(), nameof(myEnum));

IEnumerable<int> myEnum()
{
    for (int i = 0; i < 5; i++) yield return i;
}

void sub(IEnumerable<int> enu, string label)
{
    var r = enu.TryGetNonEnumeratedCount(out int count);
    if (r) Console.WriteLine($"{label}の要素数は{count}");
    else Console.WriteLine($"{label}の要素数は計測不能");
}
