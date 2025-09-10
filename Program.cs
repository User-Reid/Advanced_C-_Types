var fishyStruct1 = new FishyStruct { Numbers = new List<int> { 1, 2, 3 } };
var fishyStruct2 = fishyStruct1;

fishyStruct2.Numbers.Clear();

Console.ReadKey();

struct FishyStruct
{
  public List<int> Numbers { get; init; }
}

struct Point
{
  public int X { get; set; }
  public int Y { get; set; }

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