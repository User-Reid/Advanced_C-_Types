// Point nullPoint = null;
Person person = new Person();
Console.ReadKey();

 struct Point
{
  public int X { get; set; }
  public int Y { get; set; }

  public Point(int x, int y)
  {
    X = x;
    Y = y;
  }

  public override string ToString() => $"X: {X}, Y: {Y}";
}

struct DerivedPoint : Person
{
  
}

class Person
{
  private Point _favouritePoint;
  private Person _favouritePerson;
  public int Id { get; }
  public string Name { get; init; }

}