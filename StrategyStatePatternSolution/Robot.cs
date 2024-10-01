namespace StrategyStatePatternSolution
{
    // Robot class using both State and Strategy patterns
    public class Robot
    {
        private IRobotState _currentState;
        private IRobotBehavior _currentBehavior;

        // Set the current state dynamically
        public void SetState(IRobotState newState)
        {
            _currentState = newState;
            _currentState.EnterState(this);
        }

        // Change the robot's behavior within the current state
        public void ChangeBehavior(IRobotBehavior newBehavior)
        {
            _currentState.SetBehavior(this, newBehavior);
        }

        // Perform the action based on the current state and behavior
        public void PerformAction()
        {
            _currentState?.HandleAction(this);
        }

        // Set the current behavior
        public void SetBehavior(IRobotBehavior behavior)
        {
            _currentBehavior = behavior;
        }

        // Perform the current behavior
        public void PerformActionBehavior()
        {
            _currentBehavior?.PerformAction();
        }
    }
}
