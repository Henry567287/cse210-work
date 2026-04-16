using System;

public class Running : Activity
{
    private double _distance; // in km

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance > 0 ? distance : 0.1;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return GetMinutes() == 0 ? 0 : (_distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return _distance == 0 ? 0 : GetMinutes() / _distance;
    }
}