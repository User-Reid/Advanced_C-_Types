// int number = null;
string taco = null;
bool? boolOrNull = true;
int? numberOrNull = null;
// Nullable<string> stringOrNull = null;

var heights = new List<Nullable<int>> {
  160, null, 185, null, 170
};

var averageHeight = heights.Average();
System.Console.WriteLine(averageHeight);


if (numberOrNull.HasValue)
{
  int number = numberOrNull.Value;
  System.Console.WriteLine("Not null");
}
if (boolOrNull is not null)
{
  var someBool = boolOrNull.Value;
  System.Console.WriteLine(someBool);
}

Console.ReadKey();

