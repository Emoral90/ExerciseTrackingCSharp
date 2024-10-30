public abstract class Activity
{
    // Private fields
    private DateTime date;
    private int durationMinutes;

    // Constructor
    public Activity(DateTime date, int durationMinutes)
    {
        this.date = date;
        this.durationMinutes = durationMinutes;
    }

    // Properties (Encapsulation)
    public DateTime Date => date;
    public int DurationMinutes => durationMinutes;

    // Virtual methods for distance, speed, pace, and summary
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // GetSummary Method
    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} ({DurationMinutes} min): " +
               $"Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace {GetPace():0.0} min per km";
    }
}
