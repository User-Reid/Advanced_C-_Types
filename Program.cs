// var point = new Point(10, 20);

// MoveToRightBy1Unit(point);

// Console.ReadKey();

// void MoveToRightBy1Unit(Point point) {
//   point.X++;
// }

// struct FishyStruct
// {
//   public List<int> Numbers { get; init; }
// }

// struct Point
// {
//   public int X { get; init; }
//   public int Y { get; init; }

//   public Point()
//   {
//     X = 0;
//     Y = 1;
//   }

//   public Point(int x, int y)
//   {
//     X = x;
//     Y = y;
//   }

//   public override string ToString() => $"X: {X}, Y: {Y}";
// }

// class Person
// {
//   private Point _favouritePoint;
//   private Person _favouritePerson;
//   public int Id { get; }
//   public string Name { get; init; }

// }
var time = new Time(12, 8);

System.Console.WriteLine(time);

Console.ReadKey();

public struct Time
{
  public int Hour { get; }
  public int Minute { get; }

  public Time(int hour, int minute)
  {
    Hour = hour;
    Minute = minute;

    if (hour < 0 || hour > 23 || minute < 0 || minute > 59)
    {
      throw new ArgumentOutOfRangeException();
    }
  }

  public override string ToString() => $"{Hour.ToString("00")}:{Minute.ToString("00")}";
}