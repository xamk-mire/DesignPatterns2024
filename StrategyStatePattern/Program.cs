namespace StrategyStatePattern
{
    // Robot class
    public class Robot
    {
        public string Mode { get; set; } = default!;

        public void PerformAction()
        {
            if (Mode?.ToLower() == "idle")
            {
                Console.WriteLine("The robot is idling.");
            }
            else if (Mode?.ToLower() == "working")
            {
                Console.WriteLine("The robot is working.");
            }
            else if (Mode?.ToLower() == "charging")
            {
                Console.WriteLine("The robot is charging.");
            }
            else
            {
                Console.WriteLine("Unknown mode. The robot is idle.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            robot.Mode = "idle";
            robot.PerformAction(); // Output: The robot is idling.

            robot.Mode = "working";
            robot.PerformAction(); // Output: The robot is working.

            robot.Mode = "charging";
            robot.PerformAction(); // Output: The robot is charging.
        }
    }
}
