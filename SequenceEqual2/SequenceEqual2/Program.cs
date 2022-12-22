A[] a1 = { new A("ALICE"), new A("BETTY") };
A[] a2 = { new A("alice"), new A("betty") };

Console.WriteLine(a1.SequenceEqual(a2));

class A : IEquatable<A>
{
    public string Message { get; set; }
    // EqualsとGetHashCodeをoverrideして
    // 一致動作を一致させることが望ましい

    public bool Equals(A? other) =>
        // 大文字小文字を同一視した判定
        Message.ToLower() == other?.Message.ToLower();

    public A(string s) => Message = s;
}


