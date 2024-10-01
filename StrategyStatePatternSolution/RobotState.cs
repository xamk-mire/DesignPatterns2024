namespace StrategyStatePatternSolution
{
    // State interface for robot states
    public interface IRobotState
    {
        void EnterState(Robot robot);
        void HandleAction(Robot robot);
        void SetBehavior(Robot robot, IRobotBehavior behavior);
    }

    // Idle state where robot can rest or perform surveillance
    public class IdleState : IRobotState
    {
        public void EnterState(Robot robot)
        {
            Console.WriteLine("Entering Idle State.");
            robot.SetBehavior(new IdleBehavior());
        }

        public void HandleAction(Robot robot)
        {
            robot.PerformActionBehavior();
        }

        public void SetBehavior(Robot robot, IRobotBehavior behavior)
        {
            robot.SetBehavior(behavior);
        }
    }

    // Working state where robot can do different work types
    public class WorkingState : IRobotState
    {
        public void EnterState(Robot robot)
        {
            Console.WriteLine("Entering Working State.");
            robot.SetBehavior(new WorkingBehavior()); // Default behavior
        }

        public void HandleAction(Robot robot)
        {
            robot.PerformActionBehavior();
        }

        public void SetBehavior(Robot robot, IRobotBehavior behavior)
        {
            robot.SetBehavior(behavior);
        }
    }

    // Charging state where robot charges its batteries
    public class ChargingState : IRobotState
    {
        public void EnterState(Robot robot)
        {
            Console.WriteLine("Entering Charging State.");
            robot.SetBehavior(new ChargingBehavior());
        }

        public void HandleAction(Robot robot)
        {
            robot.PerformActionBehavior();
        }

        public void SetBehavior(Robot robot, IRobotBehavior behavior)
        {
            Console.WriteLine("Cannot change behavior while charging.");
        }
    }
}
