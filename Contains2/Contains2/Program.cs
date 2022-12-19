using System.Diagnostics.CodeAnalysis;

Person[] persons = {
    new Person("Jun",18),
    new Person("Jinpei",20),
    new Person("Ken",18),
};

Person Joe = new Person("Joe", 20);

var r = persons.Contains(Joe, new MyComparer()) ? "いる" : "いない";
Console.WriteLine($"{Joe.Name}と同じ年齢の人は{r}");

record Person(string Name, int Age);

class MyComparer : IEqualityComparer<Person>
{
    public bool Equals(Person? x, Person? y)
    {
        return x?.Age == y?.Age;
    }

    public int GetHashCode([DisallowNull] Person obj)
    {
        return obj.Age.GetHashCode();
    }
}
