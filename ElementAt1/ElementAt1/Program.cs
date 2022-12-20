string[] a = { "Taro", "Jiro", "Saburo", "Siro" };

// 配列の添え字を使う
Console.WriteLine(a[2]);

// LINQ(ElementAt)を使う
Console.WriteLine(a.ElementAt(2));

// LINQ(ElementAtOrDefault)を使う
Console.WriteLine(a.ElementAtOrDefault(4));

// 最後の1つを取得する
Console.WriteLine(a.ElementAt(^1));
