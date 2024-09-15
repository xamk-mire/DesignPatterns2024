# Exercise: Refactoring Code with Factory and Abstract Factory Patterns

## Objective

Refactor the existing code to use Factory and Abstract Factory design patterns. This exercise will help you understand how these patterns can be used to solve common programming problems related to object creation. Additionally, you will extend the Abstract Factory pattern to create products (vehicles) from different brands.

## Problem Description

You are given an initial implementation of a simple application that creates different types of `Vehicles`. The current implementation uses a basic `switch` statement to create objects, making the code rigid and difficult to extend. Your task is to refactor the code using the Factory and Abstract Factory patterns, and to extend it further to support vehicle creation for different brands like `Toyota` and `Honda`.

## Task

1. **Identify Issues:**

   - The current implementation uses a `switch` statement in the `VehicleFactory` class, making it hard to extend and maintain.
   - Adding a new vehicle type requires modifying the `VehicleFactory` class, violating the Open/Closed Principle.

2. **Refactor Using Factory Pattern:**

   - Refactor the code to use a separate factory for each vehicle type (e.g., `CarFactory`, `BikeFactory`, `TruckFactory`).
   - Modify the `VehicleFactory` class to delegate the creation to the appropriate factory.

3. **Refactor Using Abstract Factory Pattern:**

   - Implement an abstract factory that allows creating families of related objects without specifying their concrete classes.
   - Create a new abstract factory class `VehicleAbstractFactory` and concrete factories that implement this abstract factory.

4. **Extend the Abstract Factory to Support Different Brands:**
   - Refactor the abstract factory to support vehicle creation for different brands (e.g., `Toyota`, `Honda`).
   - Create separate factories for each brand (`ToyotaFactory`, `HondaFactory`) that implement the abstract factory interface.
   - Implement brand-specific vehicle classes (e.g., `ToyotaCar`, `HondaBike`).

## Expected Refactored Code

- Create new classes for each specific factory.
- Refactor the code to remove the `switch` statement and make the design more flexible and extendable.
- Use the Abstract Factory pattern to handle different vehicle creation scenarios.
- Add brand-specific factories and vehicle classes to extend the Abstract Factory pattern.

## Hints

- **Factory Pattern:** Create a separate factory for each vehicle type and use it to encapsulate the object creation logic.
- **Abstract Factory Pattern:** Define an interface for creating objects but let subclasses decide which class to instantiate.
- Brand Extension: Create separate abstract factory implementations for each brand, which should produce brand-specific vehicles.
