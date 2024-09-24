# Exercise: Refactoring with Strategy and State Patterns

## Objective

Refactor the existing code to use Strategy and State design patterns. 
This exercise will help you understand how these patterns can be used to solve common programming problems related to behavior selection and state management.

## Problem Description

You are given an initial implementation of a simple application that simulates the behavior of a `Robot`. 
The current implementation uses conditional statements (`if-else`) to determine the robot's behavior based on its current mode (e.g., `Idle`, `Working`, `Charging`). 
Your task is to refactor the code using the Strategy pattern to dynamically change the robot's behavior and the State pattern to manage the robot's different states. 
Additionally, the robot should be able to switch between different behaviors within a given state.

## Task

1. **Identify Issues:**
    - The current implementation uses a `if-else` statement in the `PerformAction` method, making it hard to extend and maintain.
    - Adding a new behavior or state requires modifying the `PerformAction` method, violating the Open/Closed Principle.
    - The robot's behavior is tightly coupled with its state, making it hard to dunamically change the behavior within a state.

---

2. **Refactor Using Strategy Pattern:**
    - Implement the Strategy pattern to encapsulate the robot's behaviors.
    - Define an interface `IRobotBehavior` with a method `PerformAction`.
    - Create concrete behavior classes like `ConstructionBehavior`, `MaintenanceBehavior`, `SurveillanceBehavior`, etc., that implement the `IRobotBehavior` interface.
    - Refactor the `Robot` class to use the `IRobotBehavior` interface to perform actions dynamically.

### Instructions:

- **Step 1:** Create the `IRobotBehavior` interface with a method `PerformAction()`.
  
- **Step 2:** Implement the following concrete behavior classes:
    - `WorkingBehavior`: The robot performs work activity.
    - `MaintenanceBehavior`: The robot performs maintenance work.
    - `SurveillanceBehavior`: The robot conducts surveillance.
    - `IdleBehavior`: The robot is resting.
    - `ChargingBehavior`: The robot is charging its batteries.

- **Step 3:** Modify the `Robot` class to include a method `SetBehavior(IRobotBehavior behavior)` to set the current behavior dynamically.
  
- **Step 4:** Refactor the `PerformAction` method in the `Robot` class to delegate the action to the current behavior.

- **Step 5:** Test the code by switching between different behaviors at runtime.

---

3. **Refactor Using State Pattern:**
    - Implement the State pattern to manage the robot's different states (e.g., `Idle`, `Working`, `Charging`).
    - Define an interface `IRobotState` with methods `EnterState`, `HandleAction`, and `SetBehavior`.
    - Create concrete state classes like `IdleState`, `WorkingState`, and `ChargingState` that implement the `IRobotState` interface.
    - Each state should manage its own behaviors using the Strategy pattern.
    - Modify the `Robot` class to switch states dynamically and use the current state's behaviors.

### Instructions:

- **Step 1:** Create the `IRobotState` interface with the following methods:
  - `EnterState(Robot robot)`: This method is called when the robot enters a new state.
  - `HandleAction(Robot robot)`: This method handles the actions the robot performs in the current state.
  - `SetBehavior(Robot robot, IRobotBehavior behavior)`: This method allows setting a new behavior for the robot within the current state.

- **Step 2:** Implement the following concrete state classes:
  - **IdleState:**
    - Default behavior: `IdleBehavior`.
    - Allows switching to `SurveillanceBehavior` using the `SetBehavior` method.
  - **WorkingState:**
    - Default behavior: `WorkingBehavior`.
    - Allows switching to `MaintenanceBehavior` using the `SetBehavior` method.
  - **ChargingState:**
    - Default behavior: `ChargingBehavior`.
    - Does not allow changing behavior; any attempt should result in an error message.

- **Step 3:** Modify the `Robot` class to include a method `SetState(IRobotState newState)` to set the current state dynamically.

- **Step 4:** Refactor the `PerformAction` method in the `Robot` class to delegate the action to the current state.

- **Step 5:** Test the code by switching between different states and behaviors at runtime.

## Expected Refactored Code

- Create a new `IRobotBehavior` interface with a `PerformAction` method.
- Implement concrete behavior classes (`IdleBehavior`, `WorkingBehavior`, `ChargingBehavior`) that implement `IRobotBehavior`.
- Use the Strategy pattern in the `Robot` class to set its behavior dynamically.
- Implement a `RobotState` interface with methods like `EnterState` and `HandleAction`.
- Create concrete state classes (`IdleState`, `WorkingState`, `ChargingState`) that implement the `RobotState` interface.
- Refactor the `Robot` class to use the State pattern to manage its states.

## Hints

- **Strategy Pattern:** Use this pattern to encapsulate different behaviors that the robot can perform. The robot should be able to switch its behavior at runtime.
- **State Pattern:** Use this pattern to represent the robot's various states and manage state transitions. The robot should change its behavior based on its current state.
