string[] a = { "Anderson", "Brian", "Hanazono" };
string[] b = { "Alice", "Antonio", "Hanako" };
var q = a.GroupJoin(b, c => c[0], d => d[0], (x, e) => new { x, e });

foreach (var n in q)
    foreach (var m in n.e)
        Console.WriteLine($"{m} {n.x}");
