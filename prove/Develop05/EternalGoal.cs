namespace EternalQuest
{
    // Derived class for eternal goals
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
            // Eternal goals are never complete
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetDetailsString()
        {
            return $"{ShortName}: {Description} - {Points} points (Eternal)";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{ShortName},{Description},{Points}";
        }
    }
}
