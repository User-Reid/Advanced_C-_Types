var point = new Point(10, 20);

var dateTime = new DateTime(2023, 6, 7);
var dateWeekAfter = dateTime.AddDays(7);

Console.ReadKey();

struct Point
{
  public int X { get; init; }
  public int Y { get; init; }

  public Point()
  {
    X = 0;
    Y = 1;
  }

  public Point(int x, int y)
  {
    X = x;
    Y = y;
  }

  public override string ToString() => $"X: {X}, Y: {Y}";
}

class Person
{
  private Point _favouritePoint;
  private Person _favouritePerson;
  public int Id { get; }
  public string Name { get; init; }
}