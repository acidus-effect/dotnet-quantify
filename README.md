# Quantify ![ci branch parameter](https://github.com/acidicsoftware/dotnet-quantify/workflows/Continuous%20Integration/badge.svg?branch=trunk)

<img src="assets/quantify-logo.png" height="180px" width="180px" align="center" />

Quantify is a framework that strives to make it easier, to handle quantities with different units in your .NET based applications.

## Features
- Based on .NET Standard 1.0 for increased compatibility.
- Include quantities in calculations with both primitives and other quantities of the same unit.
- Convert quantities from one unit to another.
- Make you own quantity that suit your needs.
- Supports enum based units with static unit values and units with dynamic values by implementing your own [UnitRepository](src/Quantify/Repository/UnitRepository.cs).

### Creating a Quantity
Quantify combines a value and a unit into a quantity.

```csharp
var height = Length.Create(1.89, Unit.Metre);
```

### Converting a Quantity to Another Unit
Quantities can easily be converted from on unit to another.

```csharp
var distanceInMetres = Length.Create(1250, Unit.Metre);
var distanceInKilometres = distanceInMetres.ToUnit(Unit.Kilometre);
var distance = distanceInKilometres.Value; // distance = 1.25 kilometres
```

### Arithmetic Operations with Primitives
Quantify quantities supports basic arithmetic operations with primitives. These operations are available as both methods and operators. 

```csharp
var distanceToMall = Length.Create(2.22, Unit.Kilometre);
var distanceBothWays = distanceToMall * 2; // distanceBothWays = 4.44 kolimetres 
```

### Arithmetic Operations Between Quantities
Quantify quantities also support basic arithmetic arithmetic with other quantities. These operations are available as both methods and operators.

```csharp
var swimmingDistance = Length.Create(3.86, Unit.Kilometre);
var bikingDistance = Length.Create(180.25, Unit.Kilometre);
var runningDistance = Length.Create(42.20, Unit.Kilometre);

var totalIronman = swimmingDistance + bikingDistance + runningDistance;
// OR
var totalIronman = swimmingDistance.Add(bikingDistance).Add(runningDistance);
```
### Order of Operations
When multiple quantities with different units are involved in an operation, the result of the operation is always of the same type, as the quantity on the left hand side of the operation.

```csharp
var distanceFromWorkToHome = Length.Create(62.5, Unit.Kilometre);
var distanceFromHomeToPool = Length.Create(102, Unit.Feet);

var totalDistanceFromWorkToPool = distanceFromWorkToHome + distanceFromHomeToPool;
```

In this case the quantity `totalDistanceFromWorkToPool` is in kilometres.

## Quantify Implementations

| Name | Status | Description |
| :--- | :--- | :--- |
| [Quantify.Length](https://github.com/acidicsoftware/dotnet-quantify-length) | Airborn | Work with quantities representing lengths |
| Quantify.Area | Planned | Work with quantities representing areas  |
| Quantify.Volume | Planned | Work with quantities representing volumes |
| Quantify.Weight | Planned | Work with quantities representing weights |
|||
| Quantify.Extensions.Area | Planned | Adds support for the multiplication operator between two [Quantify.Length](https://github.com/acidicsoftware/dotnet-quantify-length)'s, the result of which is an instance of Quantify.Area |
| Quantify.Extensions.Volume | Planned | Adds support for the multiplication operator between a Quantify.Area and a [Quantify.Length](https://github.com/acidicsoftware/dotnet-quantify-length), the result of which is an instance of Quantify.Volume |

## Make Your Own Quantity
If non of the existing Quantify implementations suits your needs, you can easily implement your own in little to no time. All your need is this core library and a unit repository.

### The Quantity
Start by installing the Nuget package Quantify.

Create a new class the custom quantity. This class must inherit the abstract class `Quantity`.

```csharp
public sealed class CustomQuantity : Quantity<double, Unit, CustomQuantity>
{
    private CustomQuantity(double value, Unit unit, UnitRepository<Unit> unitRepository) : base(value, unit, unitRepository)
    {
    }

    private CustomQuantity(double value, Unit unit, UnitRepository<Unit> unitRepository, ValueCalculator<double> valueCalculator, ValueConverter<double, Unit> valueConverter) : base(value, unit, unitRepository, valueCalculator, valueConverter)
    {
    }

    public static CustomQuantity Create(double value, Unit unit)
    {
        var unitRepository = new EnumUnitRepository<Unit>();
        return new Length(value, unit, unitRepository);
    }

    protected override CustomQuantity CreateInstance(double value, Unit unit, UnitRepository<Unit> unitRepository, ValueCalculator<double> valueCalculator, ValueConverter<double, Unit> valueConverter)
    {
        return new CustomQuantity(value, unit, unitRepository, valueCalculator, valueConverter);
    }
}
```

The abstract class `Quantity` has three generic arguments.

- The **first argument** defines the type of the value stored in the quantity. The supported types are `double` and `decimal` so far.
- The **second argument** defines the type of the unit stored in the quantity. In this case it's an enum, but it might as well be a string, an int or an object. This type is the same type your unit repository use to retrive information about a specific unit.
- The **third argument** is the quantity class itself.

### The Repository
If your unit values are static, universal constants, like length and weight units, and if you plan on using an enum to represent unit values, then [Quantify.Repository.Enum](https://github.com/acidicsoftware/dotnet-quantify-repository-enum) might be useful. This library contains a complete implementation of an enum based unit repository. Please refer to the [documentation](https://github.com/acidicsoftware/dotnet-quantify-repository-enum) for more details.

To implement a custom unit repository, create a new class that implements the interface [UnitRepository](src/Quantify/Repository/UnitRepository.cs).

```csharp
public class CustomUnitRepository : UnitRepository<string> {
    public double? GetUnitValueInBaseUnits(string unit) {
        // Fetch unit value in base units
    }
    
    public decimal? GetPreciseUnitValueInBaseUnits(TUnit unit) {
        // Fetch precise unit value in base units
    }
}
```

The interface defines two methods. Both methods must return the unit value in base units, for the requested unit. For example, if the SI unit metre is the base unit, then a request for the SI unit kilometre would return 1000, since 1 kilometre represents 1000 base units (metres).

`GetUnitValueInBaseUnits` returns the unit value in base units as a `double`. This is for use in calculations where performance is favored above precision. The opposite is true for `GetPreciseUnitValueInBaseUnits`. This method return the unit value in base units as a `decimal`. This is for use in calculations where precision is favored above performance.

*Quantify is Copyright © 2020 Michel Gammelgaard, Contributors All rights reserved - Provided under the [MIT license](LICENSE)*

*The flask icon is Copyright © 2020 Michel Gammelgaard All rights reserved*