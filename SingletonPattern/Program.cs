namespace SingletonPattern
{
    // Singleton Class for LoginManager
    public class LoginManager
    {
        // Step 1: Create a private static instance of the class (Singleton)
        private static LoginManager? instance;

        // Private variable to store the logged-in user's username
        private string? loggedInUser;

        // Step 2: Make the constructor private to prevent instantiation
        private LoginManager()
        {
            // Initialization code here
            loggedInUser = null;
        }

        // Step 3: Provide a public static method to get the instance of the class
        public static LoginManager GetInstance()
        {
            if (instance == null)
            {
                // Lazily initialize the instance
                instance = new LoginManager();
            }
            return instance;
        }

        // Method to handle user login
        public bool Login(string username, string password)
        {
            // Dummy check for username and password (for demonstration purposes)
            if (username == "admin" && password == "password")
            {
                loggedInUser = username;
                Console.WriteLine("Login successful! Welcome, " + username);
                return true;
            }
            else
            {
                Console.WriteLine("Login failed! Invalid username or password.");
                return false;
            }
        }

        // Method to logout the current user
        public void Logout()
        {
            if (loggedInUser != null)
            {
                Console.WriteLine("User " + loggedInUser + " has been logged out.");
                loggedInUser = null;
            }
            else
            {
                Console.WriteLine("No user is currently logged in.");
            }
        }

        // Method to check if a user is logged in
        public bool IsLoggedIn()
        {
            return loggedInUser != null;
        }

        // Method to get the logged-in user's username
        public string GetLoggedInUser()
        {
            return loggedInUser ?? "none";
        }
    }

    // Main Class to Test the LoginManager Singleton
    public class Program
    {
        public static void Main(string[] args)
        {
            // Fetch the Singleton instance of LoginManager
            LoginManager loginManager = LoginManager.GetInstance();

            // Attempt to log in with the correct credentials
            loginManager.Login("admin", "password");

            // Check if the user is logged in
            if (loginManager.IsLoggedIn())
            {
                Console.WriteLine("Current logged-in user: " + loginManager.GetLoggedInUser());
            }

            // Attempt to log in with incorrect credentials
            loginManager.Login("user", "wrongpassword");

            // Log out the current user
            loginManager.Logout();

            // Attempt to log out when no user is logged in
            loginManager.Logout();
        }
    }
}
