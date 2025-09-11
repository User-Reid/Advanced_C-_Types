var dictionary = new Dictionary<Point, int>();
var point1 = new Point(27, 1);
dictionary[point1] = 99;
var point2 = new Point(27, 1);

System.Console.WriteLine(point1.GetHashCode());
System.Console.WriteLine(point2.GetHashCode());

System.Console.WriteLine(dictionary[point2]);


Console.ReadKey();

readonly struct Point : IEquatable<Point>
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

  public bool Equals(Point other)
  {
    return X == other.X && Y == other.Y;
  }

  public override bool Equals(object? obj)
  {
    return obj is Point point && Equals(point);
  }

  public override string ToString() => $"X: {X}, Y: {Y}";

  public static Point operator +(Point a, Point b) => new Point(a.X + b.X, a.Y + b.Y);

  public static bool operator ==(Point point1, Point point2) => point1.Equals(point2);
  public static bool operator !=(Point point1, Point point2) => !point1.Equals(point2);

  public static implicit operator Point(Tuple<int, int> tuple) => new Point(tuple.Item1, tuple.Item2);

}

class Person
{
  private Point _favouritePoint;
  private Person _favouritePerson;
  public int Id { get; set; }
  public string Name { get; init; }

  public Person(string name, int id)
  {
    Name = name;
    Id = id;
  }

  // public override bool Equals(object? obj)
  // {
  //   return obj is Person other && Id == other.Id;
  // }
}
