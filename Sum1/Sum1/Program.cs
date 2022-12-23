int[] a = { 1, 2, 3 };
Console.WriteLine(a.Sum());

NameAndValue[] b = new NameAndValue[]
{
    new NameAndValue("Hanako",1.0),
    new NameAndValue("Taro",2.5),
    new NameAndValue("Maiko",0.2),
};
Console.WriteLine(b.Sum(c => c.Value));

record NameAndValue(string Name, double Value );
