class Swimming : Activity
{
  private int _laps;

  public Swimming(int minutes, string date, int laps) : base(minutes, date)
  {
    _laps = laps;
  }

  public override double GetDistance()
  {
    return _laps * 50 / 1000 * 0.62;
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
