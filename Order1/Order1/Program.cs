int[] a = { 2, 3, 1 };
Console.WriteLine($"オリジナルデータ: {string.Join(',',a)}");
Console.WriteLine($"Orderメソッド: {string.Join(',', a.Order())}");
Console.WriteLine($"Array.Sortメソッド: {string.Join(',', byArray(a.ToArray()))}");
Console.WriteLine($"List.Sortメソッド: {string.Join(',', byList(a.ToList()))}");

int[] byArray(int[] ar)
{
    Array.Sort(ar);
    return ar;
}

List<int> byList(List<int> list)
{
    list.Sort();
    return list;
}
