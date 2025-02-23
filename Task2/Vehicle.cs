
using System;
namespace Vehicles;
// Interface for Vehicle Actions
interface IVehicleActions
{
    void Honk();
}
// Vehicle Class
class Vehicle_Class
{
    // Readonly(Can assign a value to it once and then can't change it) Manufacture Date
    readonly string ManufactureDate;
    // Default Tax Rate const(can't change it) private(can't be accessed outside the class)
    private const double DEFAULT_TAX_RATE = 0.14;
    // Static(Universal Across All Classes) variable to keep track of number of vehicles
    static int Number_Of_Vehicles = 0;
    // Price of the vehicle
    private double price = 0;
    // Constructor
    public Vehicle_Class()
    {
        // Assigning Manufacture Date to right now
        ManufactureDate = DateTime.Now.ToString("dd/mm/yyyy");
        // Incrementing Number of Vehicles
        Number_Of_Vehicles++;
        // Printing the number of vehicles
        Console.WriteLine("Vehicle With Manufacture Date : " + ManufactureDate + " Added Successfully");
        // Printing the number of vehicles
        PrintVehicleCount();
    }
    // virtual(force the child classes to have their own implementation) Method to Drive
    protected virtual void Drive()
    {

    }
    // Static Method to Print Number of Vehicles
    static void PrintVehicleCount()
    {
        Console.WriteLine("Current Number Of Vehicles = " + Number_Of_Vehicles);
    }

    // Method to Set Price
    public void Set_Price(double price)
    {
        this.price = price;
    }
    // Method to Calculate Tax
    public void Calculate_Tax()
    {
        double tax = price * DEFAULT_TAX_RATE;
        Console.WriteLine("Your Tax is " + tax);
        Console.WriteLine("Total Including Tax = " + price + tax);
    }

}
// Car Class Inheriting Vehicle Class and Implementing IVehicleActions Interface
class Car_Class : Vehicle_Class, IVehicleActions
{
    // Method to Drive
    public void Drive()
    {
        Console.WriteLine("Car is driving swiftly,");
    }
    // Method to Honk
    public void Honk()
    {
        Console.WriteLine("Beep beep!");
    }
}
// Truck Class Inheriting Vehicle Class and Implementing IVehicleActions Interface
class Truck_Class : Vehicle_Class, IVehicleActions
{
    // Method to Drive
    public void Drive()
    {
        Console.WriteLine("Truck is driving steadily.");
    }
    // Method to Honk
    public void Honk()
    {
        Console.WriteLine("HONK HONK!");
    }
}
// Main Class
internal class Program
{
    // Main Method
    static void Main(string[] args)
    {
        // Creating Car Object
        Car_Class car = new Car_Class();
        // Honking the Car
        car.Honk();
        // Setting Price of the Car
        car.Set_Price(10000);
        // Calculating Tax
        car.Calculate_Tax();
        // Creating Truck Object
        Truck_Class truck = new Truck_Class();
        // Honking the Truck
        truck.Honk();
        // Setting Price of the Truck
        Car_Class car2 = new Car_Class();
        // Driving the Car
        car2.Drive();
        // Setting Price of the Car
        Truck_Class truck2 = new Truck_Class();
        // Driving the Truck
        truck2.Drive();
    }
}


