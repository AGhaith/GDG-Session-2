# Vehicle Management System

## Overview
This C# console application demonstrates object-oriented programming principles through a vehicle management system. It incorporates abstraction, inheritance, interfaces, static members, and constants.

## Requirements & Features

### 1. Abstract Class – Vehicle
- **Abstract Class `Vehicle_Class`**
  - Serves as a base class for all vehicles.
  - Implements an **abstract method** `Drive()` to be overridden by derived classes.
  - Contains a **readonly field** `ManufactureDate`, assigned at object creation.
  - Defines a **constant field** `DEFAULT_TAX_RATE` (14%) for tax calculation.
  - Maintains a **static member** `Number_Of_Vehicles` to count the created vehicle instances.
  - Provides a **static method** `PrintVehicleCount()` to display the total number of vehicles.

### 2. Interface – IVehicleActions
- **Interface `IVehicleActions`**
  - Declares a `Honk()` method, which each vehicle class implements with its own honking behavior.

### 3. Concrete Classes – Car and Truck
- **Class `Car_Class`**
  - Inherits from `Vehicle_Class`.
  - Implements `IVehicleActions`.
  - Overrides `Drive()` with "Car is driving swiftly."
  - Implements `Honk()` with "Beep beep!"

- **Class `Truck_Class`**
  - Inherits from `Vehicle_Class`.
  - Implements `IVehicleActions`.
  - Overrides `Drive()` with "Truck is driving steadily."
  - Implements `Honk()` with "HONK HONK!"

### 4. Program Execution
- The `Main` method creates instances of `Car_Class` and `Truck_Class`.
- Calls their `Drive()` and `Honk()` methods.
- Uses the `DEFAULT_TAX_RATE` constant to calculate taxes based on the vehicle's price.
- Displays the total vehicle count using `PrintVehicleCount()`.

## Installation & Usage
1. Clone this repository.
2. Open the project in Visual Studio or any C# IDE.
3. Run the program to see vehicle objects being created, honking, and calculating taxes.

## Example Output
```
Vehicle With Manufacture Date : 24/02/2025 Added Successfully
Current Number Of Vehicles = 1
Beep beep!
Your Tax is 1400
Total Including Tax = 11400
...
Truck is driving steadily.
```

## Notes
- `ManufactureDate` is assigned at creation and cannot be modified.
- `Number_Of_Vehicles` is shared across all instances.

## License
This project is for educational purposes. Feel free to modify and expand it!

