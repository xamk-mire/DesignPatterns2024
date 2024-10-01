namespace StrategyStatePatternSolution
{
    // Strategy interface for robot behaviors
    public interface IRobotBehavior
    {
        void PerformAction();
    }

    // Concrete strategy classes
    public class WorkingBehavior : IRobotBehavior
    {
        public void PerformAction() => Console.WriteLine("The robot is performing work activity.");
    }

    public class MaintenanceBehavior : IRobotBehavior
    {
        public void PerformAction() => Console.WriteLine("The robot is performing maintenance work.");
    }

    public class SurveillanceBehavior : IRobotBehavior
    {
        public void PerformAction() => Console.WriteLine("The robot is conducting surveillance.");
    }

    public class IdleBehavior : IRobotBehavior
    {
        public void PerformAction() => Console.WriteLine("The robot is resting.");
    }

    public class ChargingBehavior : IRobotBehavior
    {
        public void PerformAction() => Console.WriteLine("The robot is charging its batteries.");
    }
}
