using System.Diagnostics.CodeAnalysis;

A[] a1 = { new A("ALICE"), new A("BETTY") };
A[] a2 = { new A("alice"), new A("betty") };

Console.WriteLine(a1.SequenceEqual(a2,new Eq()));
Console.WriteLine(a1.SequenceEqual(a2));

class A
{
    public string Message { get; set; }
    public A(string s) => Message = s;
}

class Eq : IEqualityComparer<A>
{
    public bool Equals(A? x, A? y) => x?.Message.ToLower() == y?.Message.ToLower();
    public int GetHashCode([DisallowNull] A obj) => obj.GetHashCode();
}
