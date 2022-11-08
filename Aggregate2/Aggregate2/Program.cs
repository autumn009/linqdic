var words = "The quick brown fox jumps over the lazy dog".Split(' ');
var s = words.Aggregate("Result 40 chars:", (tempstr, word) =>
{
    if (tempstr.Length > 40)
        return tempstr;
    else
        return tempstr + " " + word;
}, (s) => s.Split(" "));
foreach (var item in s) Console.WriteLine(item);
Console.WriteLine($"s.Length={s.Length}");
