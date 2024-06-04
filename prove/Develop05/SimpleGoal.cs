namespace EternalQuest
{
    // Derived class for simple goals
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
            _isComplete = false;
        }

        public override void RecordEvent()
        {
            _isComplete = true;
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetDetailsString()
        {
            return $"{ShortName}: {Description} - {Points} points (Complete: {_isComplete})";
        }

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal:{ShortName},{Description},{Points},{_isComplete}";
        }
    }
}