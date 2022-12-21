Person[] p =
{
    new Person(1,"一之瀬"),
    new Person(2,"二階堂"),
    new Person(1,"一橋"),
};
foreach (var item in p.GroupBy(c => c.Grade))
{
    Console.WriteLine("{0}年生グループ", item.Key);
    foreach (var item2 in item) Console.WriteLine(item2.Name);
}

record Person(int Grade,string Name);
