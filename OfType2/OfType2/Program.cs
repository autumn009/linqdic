object[] o = { 1u, 1L, 1m, 1, "1", new object() };
Console.WriteLine(o.OfType<ValueType>().Count());



