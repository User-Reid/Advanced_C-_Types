var point = new Point(10, 20);

MoveToRightBy1Unit(point);

Console.ReadKey();

void MoveToRightBy1Unit(Point point) {
  point.X++;
}

struct FishyStruct
{
  public List<int> Numbers { get; init; }
}

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