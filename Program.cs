var weatherData = new WeatherData(25.1m, 65);
System.Console.WriteLine(weatherData);

var warmerWeatherData = weatherData with { Temperature = 30 };
Console.ReadKey();

public record WeatherData(decimal Temperature, int Humidity);


// public class WeatherData : IEquatable<WeatherData?>
// {
//   public decimal Temperature { get; }
//   public int Humidity { get; }

//   public WeatherData(decimal temperature, int humidity)
//   {
//     Temperature = temperature;
//     Humidity = humidity;
//   }

//   public override string ToString() => $"Temperature: {Temperature}, Humidity: {Humidity}";

//   public override bool Equals(object? obj)
//   {
//     return obj is WeatherData other && other.Temperature == Temperature && other.Humidity == Humidity;
//   }

//   public override int GetHashCode()
//   {
//     return HashCode.Combine(Temperature, Humidity);
//   }

//   public static bool operator ==(WeatherData? left, WeatherData? right)
//   {
//     return EqualityComparer<WeatherData?>.Default.Equals(left, right);
//   }

//   public static bool operator !=(WeatherData? left, WeatherData? right)
//   {
//     return !(left == right);
//   }
  
// }