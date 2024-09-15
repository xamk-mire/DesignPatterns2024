using System;

namespace VehicleFactoryExample
{
    // Vehicle base class
    public abstract class Vehicle
    {
        public abstract void Drive();
    }

    // Concrete Vehicle classes
    public class Car : Vehicle
    {
        public override void Drive() => Console.WriteLine("Driving a car.");
    }

    public class Bike : Vehicle
    {
        public override void Drive() => Console.WriteLine("Riding a bike.");
    }

    public class Truck : Vehicle
    {
        public override void Drive() => Console.WriteLine("Driving a truck.");
    }

    // Vehicle creation class
    public class VehicleFactory
    {
        public Vehicle CreateVehicle(string type)
        {
            switch (type.ToLower())
            {
                case "car":
                    return new Car();
                case "bike":
                    return new Bike();
                case "truck":
                    return new Truck();
                default:
                    throw new ArgumentException("Invalid vehicle type.");
            }
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new VehicleFactory();

            // Creating vehicles
            Vehicle car = factory.CreateVehicle("car");
            car.Drive();

            Vehicle bike = factory.CreateVehicle("bike");
            bike.Drive();

            Vehicle truck = factory.CreateVehicle("truck");
            truck.Drive();
        }
    }
}