var words = "The quick brown fox jumps over the lazy dog".Split(' ');
var s = words.Aggregate("Result with in 40 chars: ",(tempstr, word) =>
{
    if (tempstr.Length > 40)
        return tempstr;
    else
        return tempstr + " " + word;
});
Console.WriteLine($"s=\"{s}\"");
Console.WriteLine($"s.Length={s.Length}");
