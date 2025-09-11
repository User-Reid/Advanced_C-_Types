// // var point1 = new Point(27, 1);
// // var point2 = new Point(27, 1);
// // var point3 = new Point(6, -1);
// // System.Console.WriteLine(point1.GetHashCode());
// // System.Console.WriteLine(point2.GetHashCode());
// // System.Console.WriteLine(point3.GetHashCode());
// var person1 = new Person("Martin", 6);
// var person2 = new Person("Martin", 6);
// var person3 = new Person("Bella", 7);
// System.Console.WriteLine(person1.GetHashCode());
// System.Console.WriteLine(person2.GetHashCode());
// System.Console.WriteLine(person3.GetHashCode());

// Console.ReadKey();

// readonly struct Point : IEquatable<Point>
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

//   public bool Equals(Point other)
//   {
//     return X == other.X && Y == other.Y;
//   }

//   public override bool Equals(object? obj)
//   {
//     return obj is Point point &&
//     Equals(point);
//   }

//   public override int GetHashCode()
//   {
//     return HashCode.Combine(X, Y);
//   }

//   public override string ToString() => $"X: {X}, Y: {Y}";

//   public static Point operator +(Point a, Point b) => new Point(a.X + b.X, a.Y + b.Y);

//   public static bool operator ==(Point point1, Point point2) => point1.Equals(point2);
//   public static bool operator !=(Point point1, Point point2) => !point1.Equals(point2);

//   public static implicit operator Point(Tuple<int, int> tuple) => new Point(tuple.Item1, tuple.Item2);

// }

// class Person
// {
//   private Point _favouritePoint;
//   private Person _favouritePerson;
//   public int Id { get; set; }
//   public string Name { get; init; }

//   public Person(string name, int id)
//   {
//     Name = name;
//     Id = id;
//   }

//   public override int GetHashCode()
//   {
//     return Id;
//   }

//   // public override bool Equals(object? obj)
//   // {
//   //   return obj is Person other && Id == other.Id;
//   // }
// }

Console.ReadKey();

public struct Time
{
  public int Hour { get; }
  public int Minute { get; }

  public Time(int hour, int minute)
  {
    if (hour < 0 || hour > 23)
    {
      throw new ArgumentOutOfRangeException(
          "Hour is out of range of 0-23");
    }
    if (minute < 0 || minute > 59)
    {
      throw new ArgumentOutOfRangeException(
          "Minute is out of range of 0-59");
    }
    Hour = hour;
    Minute = minute;
  }

  public override string ToString() =>
      $"{Hour.ToString("00")}:{Minute.ToString("00")}";

  public bool Equals(object? obj)
  {
    return obj is Time other && other.Hour == Hour && other.Minute == Minute;
  }

  public override int GetHashCode()
  {
    return HashCode.Combine(Hour, Minute);
  }
}