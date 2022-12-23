int[] a = new int[2000000000];
a[a.Length - 1] = 1;
var start1 = DateTime.Now;
var bySerial = a.Count(c => c == 1);
Console.WriteLine("Normal {0}", DateTime.Now - start1);
var start2 = DateTime.Now;
var byParallel = a.AsParallel().Count(c => c == 1);
Console.WriteLine("Parallel {0}", DateTime.Now - start2);
var start3 = DateTime.Now;
var byParallel2 = a.AsParallel().AsOrdered().Count(c => c == 1);
Console.WriteLine("Ordered {0}", DateTime.Now - start3);
var start4 = DateTime.Now;
var byParallel3 = a.AsParallel().AsUnordered().Count(c => c == 1);
Console.WriteLine("Unordered {0}", DateTime.Now - start4);

