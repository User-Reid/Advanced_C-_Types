// using System.Diagnostics.CodeAnalysis;

// var john = new Person("John", 1);
// var theSameAsJohn = john;
// System.Console.WriteLine(theSameAsJohn == john);
// System.Console.WriteLine(object.Equals(john, theSameAsJohn));
// theSameAsJohn = new Person("John", 1);
// System.Console.WriteLine(object.Equals(john, theSameAsJohn));
// System.Console.WriteLine();

// Console.ReadKey();

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

//   public override bool Equals(object? obj)
//   {
//     return obj is Point other && X == other.X && Y == other.Y;
//   }

//   public override string ToString() => $"X: {X}, Y: {Y}";
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

//   // public override bool Equals(object? obj)
//   // {
//   //   return obj is Person other && Id == other.Id;
//   // }
// }


Console.ReadKey();

 public class FullName
    {
        public string First { get; init; }
        public string Last { get; init; }
        
        public override string ToString() => $"{First} {Last}";

  public override bool Equals(object? obj)
  {
    return obj is FullName other && First == other.First && Last == other.Last;
  }
    }