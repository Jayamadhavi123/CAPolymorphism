using System;

// Base class: Vehicle
class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double RentalPricePerDay { get; set; }

    // Constructor
    public Vehicle(string make, string model, int year, double rentalPricePerDay)
    {
        Make = make;
        Model = model;
        Year = year;
        RentalPricePerDay = rentalPricePerDay;
    }

    // Method to calculate rental cost for a given number of days
    public virtual double CalculateRentalCost(int numberOfDays)
    {
        return RentalPricePerDay * numberOfDays;
    }
}

// Car subclass
class Car : Vehicle
{
    public int NumberOfSeats { get; set; }
    public string FuelType { get; set; }

    // Constructor
    public Car(string make, string model, int year, double rentalPricePerDay, int numberOfSeats, string fuelType)
        : base(make, model, year, rentalPricePerDay)
    {
        NumberOfSeats = numberOfSeats;
        FuelType = fuelType;
    }

    // Method specific to Car subclass
    public void Accelerate()
    {
        Console.WriteLine("Car is accelerating.");
    }
}

// Truck subclass
class Truck : Vehicle
{
    public double CargoCapacity { get; set; }
    public string TransmissionType { get; set; }

    // Constructor
    public Truck(string make, string model, int year, double rentalPricePerDay, double cargoCapacity, string transmissionType)
        : base(make, model, year, rentalPricePerDay)
    {
        CargoCapacity = cargoCapacity;
        TransmissionType = transmissionType;
    }

    // Method specific to Truck subclass
    public void LoadCargo()
    {
        Console.WriteLine("Truck is loading cargo.");
    }
}

// Motorcycle subclass
class Motorcycle : Vehicle
{
    public string BikeType { get; set; }

    // Constructor
    public Motorcycle(string make, string model, int year, double rentalPricePerDay, string bikeType)
        : base(make, model, year, rentalPricePerDay)
    {
        BikeType = bikeType;
    }

    // Method specific to Motorcycle subclass
    public void Wheelie()
    {
        Console.WriteLine("Motorcycle is performing a wheelie.");
    }
}

class Cycle
{
    static void Main(string[] args)
    {
        // Create instances of each subclass
        Car myCar = new Car("Toyota", "Camry", 2020, 50.00, 5, "Gasoline");
        Truck myTruck = new Truck("Ford", "F-150", 2018, 70.00, 1500, "Automatic");
        Motorcycle myMotorcycle = new Motorcycle("Harley-Davidson", "Sportster", 2021, 40.00, "Sport");

        // Access properties and methods inherited from the base class
        Console.WriteLine($"Car: {myCar.Make} {myCar.Model} {myCar.Year}, Seats: {myCar.NumberOfSeats}, Fuel Type: {myCar.FuelType}, Rental Price: ${myCar.RentalPricePerDay} per day");
        myCar.Accelerate();

        Console.WriteLine($"Truck: {myTruck.Make} {myTruck.Model} {myTruck.Year}, Cargo Capacity: {myTruck.CargoCapacity} lbs, Transmission Type: {myTruck.TransmissionType}, Rental Price: ${myTruck.RentalPricePerDay} per day");
        myTruck.LoadCargo();

        Console.WriteLine($"Motorcycle: {myMotorcycle.Make} {myMotorcycle.Model} {myMotorcycle.Year}, Bike Type: {myMotorcycle.BikeType}, Rental Price: ${myMotorcycle.RentalPricePerDay} per day");
        myMotorcycle.Wheelie();
    }
}