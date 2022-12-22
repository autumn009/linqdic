string[] grades = { "小学1年", "小学2年", "中学1年" };
string[] types1 = { "国語", "算数" };
string[] types2 = { "国語", "数学", "英語" };

var q = grades.SelectMany(
    t => t.Contains("小") ? types1 : types2,
    (g, t) => g + "の" + t
    );
foreach (var item in q) Console.WriteLine(item);
