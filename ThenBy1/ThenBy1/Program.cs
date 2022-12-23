Person[] p = { 
    new Person("Taro",20,170),
    new Person("Jiro",18,175),
    new Person("Hanako",20,160),
};

foreach (var item in p.OrderBy(c => c.Age).ThenBy(c => c.Tall))
{
    Console.WriteLine($"{item.Name} 年齢{item.Age} 身長{item.Tall}cm");
}

record Person(string Name, int Age, int Tall);