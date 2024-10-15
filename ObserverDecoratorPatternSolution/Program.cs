namespace ObserverDecoratorPatternSolution
{
    // Observer interface for weather updates
    public interface IWeatherObserver
    {
        string DisplayName { get; }
        void Update(string state, int temperature, string unit, string warning);
    }

    // Concrete observer for weather updates
    public class WeatherDisplay : IWeatherObserver
    {
        public string DisplayName { get; private set; }

        public WeatherDisplay(string displayName)
        {
            DisplayName = displayName;
        }

        public void Update(string state, int temperature, string unit, string warning)
        {
            Console.WriteLine($"\n[{DisplayName}] Weather Update:");

            // Create a basic reading and decorate it with additional information
            WeatherReading reading = new BasicReading(state);
            reading = new TemperatureDecorator(reading, temperature, unit);
            if (!string.IsNullOrEmpty(warning))
            {
                reading = new WarningDecorator(reading, warning);
            }
            reading.Display();
            Console.WriteLine();
        }
    }

    // WeatherStation class with Observer pattern
    public class WeatherStation
    {
        private readonly List<IWeatherObserver> _observers = new List<IWeatherObserver>();

        public string State { get; private set; }
        public int TemperatureValue { get; private set; }
        public string TemperatureUnit { get; private set; }
        public string Warning { get; private set; }

        public WeatherStation()
        {
            TemperatureUnit = "Celsius";
            Warning = string.Empty;
        }

        public void AddObserver(IWeatherObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IWeatherObserver observer)
        {
            _observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(State, TemperatureValue, TemperatureUnit, Warning);
            }
        }

        public void SetState(string state)
        {
            State = state;
            NotifyObservers();
        }

        public void SetTemperature(int value, string unit)
        {
            TemperatureValue = value;
            TemperatureUnit = unit;
            NotifyObservers();
        }

        public void SetWarning(string warning)
        {
            Warning = warning;
            NotifyObservers();
        }
    }

    // Base class for weather readings
    public abstract class WeatherReading
    {
        public abstract void Display();
    }

    // Concrete weather reading
    public class BasicReading : WeatherReading
    {
        private readonly string _state;

        public BasicReading(string state)
        {
            _state = state;
        }

        public override void Display()
        {
            Console.Write($"Weather: {_state}");
        }
    }

    // Decorator base class
    public abstract class WeatherReadingDecorator : WeatherReading
    {
        protected WeatherReading _weatherReading;

        protected WeatherReadingDecorator(WeatherReading weatherReading)
        {
            _weatherReading = weatherReading;
        }

        public override void Display()
        {
            _weatherReading.Display();
        }
    }

    // Temperature decorator
    public class TemperatureDecorator : WeatherReadingDecorator
    {
        private readonly int _temperature;
        private readonly string _unit;

        public TemperatureDecorator(WeatherReading weatherReading, int temperature, string unit)
            : base(weatherReading)
        {
            _temperature = temperature;
            _unit = unit;
        }

        public override void Display()
        {
            base.Display();
            Console.Write($", {_temperature}°{_unit}");
        }
    }

    // Warning decorator
    public class WarningDecorator : WeatherReadingDecorator
    {
        private readonly string _warning;

        public WarningDecorator(WeatherReading weatherReading, string warning)
            : base(weatherReading)
        {
            _warning = warning;
        }

        public override void Display()
        {
            base.Display();
            if (!string.IsNullOrEmpty(_warning))
            {
                Console.Write($". Warning: {_warning}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create WeatherStation and WeatherDisplay
            WeatherStation station = new WeatherStation();

            // Create displays
            WeatherDisplay display = new WeatherDisplay("Display 1");
            WeatherDisplay display2 = new WeatherDisplay("Display 2");
            WeatherDisplay display3 = new WeatherDisplay("Display 3");

            // Add displays as observers to the weather station
            station.AddObserver(display);
            station.AddObserver(display2);
            station.AddObserver(display3);

            // Change weather state and automatically notify display with decorated information
            // In real life scenario we would receive this information e.g. from weather devices or API
            station.SetState("Sunny"); // Output: [Display #] Weather Update: Weather: Sunny, 0°Celsius
            station.SetTemperature(25, "Celsius"); // Output: [Display #] Weather Update: Weather: Sunny, 25°Celsius
            station.SetWarning("UV Index is high"); // Output: [Display #] Weather Update: Weather: Sunny, 25°Celsius. Warning: UV Index is high

            Console.WriteLine();

            // Change to a new weather state
            station.SetState("Rainy"); // Output: [Display #] Weather Update: Weather: Rainy, 25°Celsius. Warning: UV Index is high
            station.SetTemperature(18, "Celsius"); // Output: [Display #] Weather Update: Weather: Rainy, 18°Celsius. Warning: UV Index is high
            station.SetWarning("Heavy rainfall expected"); // Output: [Display #] Weather Update: Weather: Rainy, 18°Celsius. Warning:Warning: Heavy rainfall expected

            Console.WriteLine();

            // Remove the warning
            station.SetWarning("");
            // Output: [Display #] Weather Update: Weather: Rainy, 18°C.
        }
    }
}
