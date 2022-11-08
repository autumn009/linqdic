int[] a = { 1, 2 };
IEnumerable<int> b = a.Append(3);

sub("a", a);
sub("b", b);

void sub(string name, IEnumerable<int> x)
{
    Console.WriteLine($"{name}={string.Join(',',x)}");
}