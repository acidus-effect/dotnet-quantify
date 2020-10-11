# Quantify ![ci branch parameter](https://github.com/acidicsoftware/dotnet-quantify/workflows/Continuous%20Integration/badge.svg?branch=trunk)

<img src="assets/quantify-logo.png" height="180px" width="180px" align="center" />

Quantify is a framework that strives to make it easier, to work with quantities in your .NET based applications.

Quantify combines a value and a unit into a quantity.

```csharp
var height = Length.Create(1.89, Unit.Metre);
```
Quantities can then be included in a variety of arithmetic operations, just as they can easily be converted to other units.

```csharp
var swimmingDistance = Length.Create(3.86, Unit.Kilometre);
var bikingDistance = Length.Create(180.25, Unit.Kilometre);
var runningDistance = Length.Create(42.20, Unit.Kilometre);

var totalIronmanInKilometres = swimmingDistance + bikingDistance + runningDistance;
var totalIronmanInMiles = totalIronmanInKilometres.ToUnit(Unit.Mile).Value;
```

You can even use quantities with different units in arithmetic operations.

```csharp
var distanceFromWorkToHome = Length.Create(62.5, Unit.Kilometre);
var distanceFromHomeToPool = Length.Create(102, Unit.Feet);

var totalDistanceFromWorkToPool = distanceFromWorkToHome + distanceFromHomeToPool;
```

When more than one unis is involved in an operation, the result is always of the same unit as the quantity on the left hand side of the operator or method. In this case `totalDistanceFromWorkToPool` is in kilometres.

## Features
- Based on .NET Standard 1.0 to increase compatibility.
- Include quantities in calculations with both primitives and other quantities of the same unit type.
- Convert quantities easily from one unit to another.
- Make you own quantity that fits your needs.
- Supports enum based units with static values and units with dynamic values by implementing your own [UnitRepository](src/Quantify/Repository/UnitRepository.cs)

## Existing Quantify Implementations

- [Quantify.Length](https://github.com/acidicsoftware/dotnet-quantify-length)
- Quantify.Area (Planned)
- Quantify.Volume (Planned)

Besides the main unit libraries, Quantify also include a few add-on libraries that integrated some of the existing Quantify implementations:

| Library | Status | Description |
| :--- | :--- | :--- |
| Quantify.Length.ToArea | Planned | Adds support for the multiplication operator between two [Quantify.Length](https://github.com/acidicsoftware/dotnet-quantify-length)'s, the result of which is an instance of Quantify.Area. |
| Quantify.Area.ToVolume | Planned | Adds support for the multiplication operator between a Quantify.Area and a [Quantify.Length](https://github.com/acidicsoftware/dotnet-quantify-length), the result of which is an instance of Quantify.Volume. |

## Make Your Own Quantity
If non of the existing Quantify implementations fits your needs, you can easily implement your own in little to no time. All your need is this core library and a unit repository. If your custom units have static values and can be represented as an enum, we've got you covered on the repository too, with the library [Quantify.Repository.Enum](https://github.com/acidicsoftware/dotnet-quantify-repository-enum).

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

- The first arguments defines the type of the value stored in the quantity. The supported types are `double` and `decimal` so far.
- The second argument defines the type of the unit stored in the quantity. In this case it's an enum, but it might as well be a string, an int or an object. It just have to uniquely identify the unit, so that your unit repository can retrive data for that unit.
- The third argument is the quantity class itself.