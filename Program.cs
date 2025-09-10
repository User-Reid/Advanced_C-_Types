var converter = new ObjectToTextConverter();
System.Console.WriteLine(converter.Convert(new House("123 Maple Road", 170.6, 2)));

Console.ReadKey();

public class ObjectToTextConverter
{
  public string Convert(object obj)
  {
    Type type = obj.GetType();
    var properties = type.GetProperties().Where(p => p.Name != "EqualityContract");

    return string.Join(", ", properties.Select(property => $"{property.Name} is {property.GetValue(obj)}"));
  }
}

public record Pet(string Name, PetType PetType, float Weight);
public record House(string Adderess, double Area, int Floors);
public enum PetType {Cat, Dog, Fish}