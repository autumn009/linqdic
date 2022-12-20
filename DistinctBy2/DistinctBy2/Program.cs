string[] names = { "Taro", "Jiro", "Saburo" };
Console.WriteLine(string.Join(',',names.DistinctBy(c=>true)));
