var a = new int[] { 1 }.DefaultIfEmpty(1);
Console.WriteLine($"{string.Join(',',a)}");