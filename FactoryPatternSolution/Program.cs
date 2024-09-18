namespace FactoryPatternSolution
{
    namespace FactoryPatterns
    {
        // Vehicle base class
        public abstract class Vehicle
        {
            public abstract void Drive();
        }

        // Concrete Vehicle classes for Toyota
        public class ToyotaCar : Vehicle
        {
            public override void Drive() => Console.WriteLine("Driving a Toyota car.");
        }

        public class ToyotaBike : Vehicle
        {
            public override void Drive() => Console.WriteLine("Riding a Toyota bike.");
        }

        public class ToyotaTruck : Vehicle
        {
            public override void Drive() => Console.WriteLine("Driving a Toyota truck.");
        }

        // Concrete Vehicle classes for Honda
        public class HondaCar : Vehicle
        {
            public override void Drive() => Console.WriteLine("Driving a Honda car.");
        }

        public class HondaBike : Vehicle
        {
            public override void Drive() => Console.WriteLine("Riding a Honda bike.");
        }

        public class HondaTruck : Vehicle
        {
            public override void Drive() => Console.WriteLine("Driving a Honda truck.");
        }

        // Abstract Factory Interface
        public interface IVehicleFactory
        {
            Vehicle CreateCar();
            Vehicle CreateBike();
            Vehicle CreateTruck();
        }

        // Toyota Factory implementing the Abstract Factory
        public class ToyotaFactory : IVehicleFactory
        {
            public Vehicle CreateCar() => new ToyotaCar();
            public Vehicle CreateBike() => new ToyotaBike();
            public Vehicle CreateTruck() => new ToyotaTruck();
        }

        // Honda Factory implementing the Abstract Factory
        public class HondaFactory : IVehicleFactory
        {
            public Vehicle CreateCar() => new HondaCar();
            public Vehicle CreateBike() => new HondaBike();
            public Vehicle CreateTruck() => new HondaTruck();
        }

        // Main Program
        class Program
        {
            static void Main(string[] args)
            {
                // Choose the factory brand you want to use
                IVehicleFactory toyotaFactory = new ToyotaFactory();
                IVehicleFactory hondaFactory = new HondaFactory();

                // Create Toyota vehicles
                Vehicle toyotaCar = toyotaFactory.CreateCar();
                toyotaCar.Drive();

                Vehicle toyotaBike = toyotaFactory.CreateBike();
                toyotaBike.Drive();

                Vehicle toyotaTruck = toyotaFactory.CreateTruck();
                toyotaTruck.Drive();

                // Create Honda vehicles
                Vehicle hondaCar = hondaFactory.CreateCar();
                hondaCar.Drive();

                Vehicle hondaBike = hondaFactory.CreateBike();
                hondaBike.Drive();

                Vehicle hondaTruck = hondaFactory.CreateTruck();
                hondaTruck.Drive();
            }
        }
    }
}
