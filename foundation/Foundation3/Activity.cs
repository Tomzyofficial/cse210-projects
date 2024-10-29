using System;

abstract class Activity
{
  private int _minutes;
  private string _date;

  public Activity(int minutes, string date)
  {
    _minutes = minutes;
    _date = date;
  }

  public int Minutes()
  {
    return _minutes;
  }

  public string Date()
  {
    return _date;
  }

  public abstract double GetDistance();
  public abstract double GetSpeed();
  public abstract double GetPace();

  public virtual string GetSummary()
  {
    return $"{Date()}: {GetType().Name} ({Minutes()} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
  }
}
