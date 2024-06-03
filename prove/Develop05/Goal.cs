namespace EternalQuest
{
    // Base class for goals
    public abstract class Goal
    {
        public string ShortName { get; private set; }
        public string Description { get; private set; }
        public int Points { get; private set; }

        public Goal(string name, string description, int points)
        {
            ShortName = name;
            Description = description;
            Points = points;
        }

        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetDetailsString();
        public abstract string GetStringRepresentation();
    }
}
