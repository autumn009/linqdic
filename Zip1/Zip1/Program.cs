string[] s1 = { "杉並", "世田谷", "三鷹" };
string[] s2 = { "区", "区", "市" };
string[] s3 = { "荻窪", "世田谷", "野崎" };
foreach (var item in s1.Zip(s2, (a, b) => a + b)) Console.WriteLine(item);
foreach (var item in s1.Zip(s2)) Console.WriteLine($"{item.First}{item.Second}");
foreach (var item in s1.Zip(s2,s3)) Console.WriteLine($"{item.First}{item.Second}{item.Third}");
