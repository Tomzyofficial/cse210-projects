class Running : Activity
{
  private double _distance;

  public Running(int minutes, string date, double distance) : base(minutes, date)
  {
    _distance = distance;
  }

  public override double GetDistance()
  {
    return _distance;
  }

  public override double GetSpeed()
  {
    return (GetDistance() / Minutes()) * 60;
  }

  public override double GetPace()
  {
    return Minutes() / GetDistance();
  }
}
