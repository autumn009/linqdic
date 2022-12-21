int[] a = { 0, 1, 2, 3 };
int r = a.FirstOrDefault(c => c % 2 != 0,-1);
if (r == -1) Console.WriteLine("見つかりません。");
else Console.WriteLine($"{string.Join(',', a)}から発見された最初の奇数は{r}です。");
