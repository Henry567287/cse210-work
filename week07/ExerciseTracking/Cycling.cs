using System;

public class Cycling : Activity
{
    private double _speed; // kph

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed > 0 ? speed : 1;
    }

    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _speed == 0 ? 0 : 60 / _speed;
    }
}