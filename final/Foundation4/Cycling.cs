public class Cycling : Activity
{
    private double speed; // in mph

    public Cycling(string date, int lengthMinutes, double speed)
        : base(date, lengthMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed * GetLengthMinutes()) / 60;
    }

    public override double GetSpeed() => speed;

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLengthMinutes()} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
