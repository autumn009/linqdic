const int ID_TARO = 1;
const int ID_JIRO = 2;

Person[] persons =
{
    new Person(ID_TARO,"Taro"),
    new Person(ID_JIRO,"Jiro"),
};
ResultPoint[] points =
{
    new ResultPoint(ID_TARO,87),
    new ResultPoint(ID_JIRO,63),
};
foreach (var item in persons.Join(points, c => c.Id, c => c.Id, (person, point) => new { person.Name, point.Point }))
{
    Console.WriteLine("{0}は{1}点です。", item.Name, item.Point);
}

record Person(int Id, string Name);
record ResultPoint(int Id, int Point);
