Person[] p = {
    new Person("Taro",new DateTime(2023,1,1)),
    new Person("Taro",new DateTime(2023,1,2)),
    new Person("Jiro",new DateTime(2023,1,3)),
    new Person("Taro",new DateTime(2023,1,4)),
    new Person("Saburo",new DateTime(2023,1,5)),
}; 

Console.WriteLine(string.Join(',',p.DistinctBy(c=>c.Name).Select(c=>c.Name)));

record Person(string Name, DateTime Time);