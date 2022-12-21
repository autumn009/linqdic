Person[] persons =
{
    new Person("Taro",20),
    new Person("Jiro",20),
    new Person("Saburo",20),
};

var r = persons.MaxBy(c=>c.Age);
Console.WriteLine($"選ばれたのは{r.Name}");

record Person(string Name, int Age);
