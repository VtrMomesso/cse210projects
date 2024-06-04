public class Running : Activity
{
    private double distance; // in miles

    public Running(string date, int lengthMinutes, double distance)
        : base(date, lengthMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed()
    {
        return (distance / GetLengthMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthMinutes() / distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLengthMinutes()} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
