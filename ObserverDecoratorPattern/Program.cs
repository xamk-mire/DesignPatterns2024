namespace ObserverDecoratorPattern
{
    // WeatherStation class directly manages state and displays readings
    public class WeatherStation
    {
        public string State { get; set; }
        public string TemperatureUnit { get; set; }
        public int TemperatureValue { get; set; }
        public string Warning { get; set; }

        public WeatherStation()
        {
            TemperatureUnit = "Celsius";
            Warning = string.Empty;
        }

        public void SetState(string state)
        {
            State = state;
            DisplayWeather();
        }

        public void SetTemperature(int value, string unit)
        {
            TemperatureValue = value;
            TemperatureUnit = unit;
            DisplayWeather();
        }

        public void SetWarning(string warning)
        {
            Warning = warning;
            DisplayWeather();
        }

        private void DisplayWeather()
        {
            Console.Write($"Weather: {State}, {TemperatureValue}°{TemperatureUnit}.");
            if (!string.IsNullOrEmpty(Warning))
            {
                Console.Write($" Warning: {Warning}.");
            }
            Console.WriteLine();
        }
    }

    // Simple weather display without using Observer pattern
    public class WeatherDisplay
    {
        public void ShowWeather(WeatherStation station)
        {
            Console.WriteLine($"Display: The weather is {station.State} with temperature {station.TemperatureValue}°{station.TemperatureUnit}.");
            if (!string.IsNullOrEmpty(station.Warning))
            {
                Console.WriteLine($"Display: Warning - {station.Warning}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation();
            WeatherDisplay display = new WeatherDisplay();

            // Manually update and display weather state
            station.SetState("Sunny");
            display.ShowWeather(station); // Output: Display: The weather is Sunny with temperature 0°C.

            station.SetTemperature(25, "Celsius");
            display.ShowWeather(station); // Output: Display: The weather is Sunny with temperature 25°C.

            station.SetWarning("UV Index is high");
            display.ShowWeather(station); // Output: Display: The weather is Sunny with temperature 25°C. Warning - UV Index is high.

            station.SetState("Rainy");
            station.SetTemperature(18, "Celsius");
            display.ShowWeather(station); // Output: Display: The weather is Rainy with temperature 18°C. Warning - UV Index is high.
        }
    }
}