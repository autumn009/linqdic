A[] a = { new B() };
foreach (var item in a.Cast<B>()) item.Hello();

object[] x = { 1, 2 };
foreach (var item in x.Cast<int>()) Console.Write($"{item} ");
Console.WriteLine();

int[] b = { 1, 2, 3 };
//var r = b.Cast<long>();   // ←できない
var r = b.Select(c => (long)c);   // ←できる
foreach (var item in r) Console.Write($"{item} ");
Console.WriteLine();

class A { }
class B : A
{
    public void Hello() => Console.WriteLine("Hello!");
}
