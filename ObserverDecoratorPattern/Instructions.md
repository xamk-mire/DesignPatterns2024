# Exercise: Refactoring with Observer and Decorator Patterns

## Objective

Refactor the existing code to use Decorator and State-Observer design patterns together. 
This exercise will help you understand how these patterns can be used to solve common programming problems related to dynamic behavior extension and change notification.

## Problem Description

You are given an initial implementation of a simple application that simulates a `WeatherStation`. 
The station directly manages its state (e.g., `Sunny`, `Rainy`, `Windy`) and displays readings using manual method calls. 
The current implementation lacks a mechanism for notifying display devices automatically when the weather changes, and it is difficult to extend weather readings with additional features (e.g., temperature units, warnings). 
Your task is to refactor the code using the **Observer** pattern for automatic updates and the **Decorator** pattern for dynamically adding features to weather readings.


## Task

### 1. Identify Issues:
- The current implementation lacks automatic updates to `WeatherDisplay` when the weather state changes, requiring manual updates.
- Adding features like different temperature units or displaying warnings is tightly coupled with the `WeatherStation` class.
- Extending functionality (e.g., adding a new weather state or temperature unit) would require modifying existing code, violating the Open/Closed Principle.

---

### 2. Refactor Using the Observer Pattern:
- Refactor the code so that `WeatherDisplay` objects automatically get notified when the `WeatherStation` state changes.
- Implement an observer interface for displays and have the `WeatherStation` maintain a list of observers to notify.

---

#### Instructions:
- **Step 1**: Create an `IWeatherObserver` interface with a method `Update()`.
- **Step 2**: Implement the `IWeatherObserver` interface in `WeatherDisplay` and modify it to update automatically.
- **Step 3**: Update the `WeatherStation` class to keep a list of observers and notify them whenever the weather state changes.

---

### 3. Refactor Using the Decorator Pattern:
- Refactor the code to use the **Decorator** pattern to dynamically add behavior to weather readings.
- Implement `WeatherReading` as a base class and create decorators to add features like `CelsiusReading`, `FahrenheitReading`, `WarningDecorator`, etc.

---

### 4. Combine the Patterns:
- Ensure that `WeatherDisplay` instances automatically receive updates from `WeatherStation` (using the **Observer** pattern).
- Use the **Decorator** pattern to allow each `WeatherDisplay` to extend the weather readings with additional information dynamically.

---

#### Instructions:
- **Step 1**: Create an abstract `WeatherReading` class with a method `Display()`.
- **Step 2**: Implement a concrete `BasicReading` class that extends `WeatherReading` and provides basic weather data.
- **Step 3**: Create decorators like `CelsiusReading` and `FahrenheitReading` that add temperature units to the display.
- **Step 4**: Create a `WarningDecorator` that displays weather warnings (e.g., high winds, heavy rain).

---

## Expected Refactored Code
- **Task 2**: Implement the `IWeatherObserver` interface and update the `WeatherStation` to notify observers automatically.
- **Task 3**: Implement the `WeatherReading` abstract class and decorators to add features dynamically to weather readings.
- **Task 4**: Combine both patterns so that `WeatherDisplay` uses decorators to enhance readings when notified by `WeatherStation`.

## Hints
- **Observer Pattern (Task 2)**: Use this pattern to ensure that `WeatherDisplay` instances are automatically updated whenever the `WeatherStation` changes its state.
- **Decorator Pattern (Task 3)**: Use this pattern to add responsibilities to weather readings without modifying the base class.
- **Combining the Patterns (Task 4)**: Use the **Observer** pattern for automatic updates and Decorator pattern to enhance weather data before displaying it.
