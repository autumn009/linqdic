var s = "The String";

// 昔ながらのスタイル
Console.WriteLine($"{s}の最後の1文字は{s.Last()}");

// 比較的新しいスタイル
Console.WriteLine($"{s}の最後の1文字は{s[^1]}");