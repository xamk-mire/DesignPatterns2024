namespace StrategyStatePatternSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            // Set the robot to Idle state and perform the default action
            robot.SetState(new IdleState()); // Output: Entering Idle State.
            robot.PerformAction(); // Output: The robot is resting.

            // Switch behavior within the Idle state
            robot.ChangeBehavior(new SurveillanceBehavior());
            robot.PerformAction(); // Output: The robot is conducting surveillance.

            // Set the robot to Working state and perform the default action
            robot.SetState(new WorkingState()); // Output: Entering Working State.
            robot.PerformAction(); // Output: The robot is performing construction work.

            // Switch behavior within the Working state
            robot.ChangeBehavior(new MaintenanceBehavior());
            robot.PerformAction(); // Output: The robot is performing maintenance work.

            // Set the robot to Charging state and perform the default action
            robot.SetState(new ChargingState()); // Output: Entering Charging State.
            robot.PerformAction(); // Output: The robot is charging its batteries.

            // Attempt to switch behavior within the Charging state
            robot.ChangeBehavior(new IdleBehavior()); // Output: Cannot change behavior while charging.
            robot.PerformAction(); // Output: The robot is charging its batteries.
        }
    }
}
