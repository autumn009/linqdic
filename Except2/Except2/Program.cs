int[] a = { 1, 2, 3, 4 };
object[] b = { 1, 3, 5, 7 };
// ↓コンパイルできない
Console.WriteLine($"{string.Join(',', a)}から" +
    $"{string.Join(',', b)}を除外すると" +
    $"{string.Join(',', a.Except(b))}");
