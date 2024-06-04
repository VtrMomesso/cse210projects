public abstract class Activity
{
    private string date;
    private int lengthMinutes;

    public Activity(string date, int lengthMinutes)
    {
        this.date = date;
        this.lengthMinutes = lengthMinutes;
    }

    public string GetDate() => date;
    public int GetLengthMinutes() => lengthMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date} ({lengthMinutes} min)";
    }
}
