int[] array = { 1, 2, 3, 4 };
int[] targets = { 3, 5 };
foreach (var item in targets)
{
    string msg = array.Contains(item) ? "います" : "いません";
    Console.WriteLine($"{string.Join(',',array)}に{item}は含まれて{msg}");
}

