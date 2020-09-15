# Quantify
Quantify is a library that makes it easier for you, to work with quantities in your .NET based applications.

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

You can event use quantities with different units in arithmetic operations.

```csharp
var distanceFromWorkToHome = Length.Create(62.5, Unit.Kilometre);
var distanceFromHomeToPool = Length.Create(102, Unit.Feet);

var totalDistanceFromWorkToPool = distanceFromWorkToHome + distanceFromHomeToPool;
```

Note that the unit of the quantity on the left hand side of an operator wins. In this case `totalDistanceFromWorkToPool` is in kilometres.

## Features
- Based on .NET Standard 1.2 to increase compatibility
- Imclude quantities in calculations with both primitives and other quantities of the same unit type.
- Convert quantities easily from one unit to another.
- Make you own quantity to fit your needs.
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
If non of the existing Quantify implementations fits your needs, then you can easily implement your own in little to no time. All your need is this core library and a unit repository. And if your units can be defined in an enum, we've got you covered on the repository too, with the library [Quantify.Repository.Enum](https://github.com/acidicsoftware/dotnet-quantify-repository-enum).

A guide on how to implement your own quantity will be available in the wiki section soon.

## Status
Some status information here...