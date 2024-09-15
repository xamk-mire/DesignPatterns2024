### Exercise: Implement a Login Feature Using the Singleton Pattern

In this exercise, you will implement a login feature using the Singleton Pattern. The goal is to create a `LoginManager` class that manages user authentication and ensures only one instance of the login manager exists throughout the application.

### Objectives

- Understand and implement the Singleton Pattern.
- Create a class that handles user login, logout, and authentication status.
- Ensure that only one instance of the login manager is created and used.

### Instructions

1. **Create the Singleton Class (`LoginManager`)**:

   - Define a class named `LoginManager`.
   - Create a private static variable inside the class to hold the instance of `LoginManager`.
   - Make the constructor of `LoginManager` private to prevent instantiation from outside the class.
   - Provide a public static method (`getInstance()`) that returns the single instance of the class. If the instance is not created, initialize it.

2. **Implement the Login Functionality**:

   - Add a private variable (`loggedInUser`) to store the username of the currently logged-in user.
   - Implement a `login()` method that accepts a username and password. For this exercise, validate the credentials using a simple condition (`username: admin`, `password: password`). If the credentials match, store the username in `loggedInUser` and display a login success message. Otherwise, display a failure message.
   - Implement a `logout()` method to clear the logged-in user and display a logout message.

3. **Add User Status Methods**:

   - Create an `isLoggedIn()` method that returns `true` if a user is currently logged in, otherwise `false`.
   - Add a `getLoggedInUser()` method that returns the username of the logged-in user.

4. **Create a Main Class for Testing**:
   - Create a `Main` class with a `main` method to test the `LoginManager`.
   - Use the `getInstance()` method to get the singleton instance of `LoginManager`.
   - Test the login feature by attempting to log in with both correct and incorrect credentials.
   - Use the `isLoggedIn()` and `getLoggedInUser()` methods to check the current user's status.
   - Test the `logout()` method to ensure it works as expected.

### Example Output

The following is an example of how the program should behave when running the `Main` class:

- Login successful! Welcome, admin
- Current logged-in user: admin
- Login failed! Invalid username or password.
- User admin has been logged out.
- No user is currently logged in.
