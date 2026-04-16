using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps >= 0 ? laps : 0;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetMinutes() == 0 ? 0 : (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return distance == 0 ? 0 : GetMinutes() / distance;
    }
}