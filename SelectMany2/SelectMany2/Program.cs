string[] grades = { "小学1年", "小学2年", "中学1年" };
string[] types1 = { "国語", "算数" };

var q = grades.SelectMany(
    t => t.Contains("小") ? types1 : Enumerable.Empty<string>(),
    (g, t) => g + "の" + t
    );
foreach (var item in q) Console.WriteLine(item);
