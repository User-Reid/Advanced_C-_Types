var tuple1 = new Tuple<string, bool>("aaa", false);
var tuple2 = Tuple.Create(10, true);
var tuple3 = Tuple.Create(10, true);
System.Console.WriteLine(tuple2 == tuple3);
System.Console.WriteLine(tuple2.Equals(tuple3));
System.Console.WriteLine(tuple2.GetHashCode());
System.Console.WriteLine(tuple3.GetHashCode());
// went over benefits from mutable and immutable types.

var number = tuple2.Item1;
// tuple2.Item1 = 20;

var valueTuple1 = new ValueTuple<int, string>(1, "bbb");
var valueTuple2 = (5, "ccc");

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
    return obj is Point point &&
    Equals(point);
  }

  public override int GetHashCode()
  {
    return HashCode.Combine(X, Y);
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

  public override int GetHashCode()
  {
    return Id;
  }

  // public override bool Equals(object? obj)
  // {
  //   return obj is Person other && Id == other.Id;
  // }
}