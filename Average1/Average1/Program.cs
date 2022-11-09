decimal[] d = { 1.1m, 1.2m, 1.3m };
Console.WriteLine(d.Average());

int?[] a = { 1, null, 2 };
Console.WriteLine(a.Average());

double?[] b = { null, null, null };
Console.WriteLine(b.Average()==null);

Tuple<string, int>[] tuples = {
    new Tuple<string,int>("Alice",2),
    new Tuple<string,int>("Betty",3),
    new Tuple<string,int>("Cindy",4),
};
Console.WriteLine(tuples.Average(c=>c.Item2));

string[] c = { "Hello", "how", "are", "you" };
Console.WriteLine(c.Average(c=>c.Length));
