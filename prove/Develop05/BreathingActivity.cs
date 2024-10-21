using System;

class BreathingActivity : Activity
{
  public BreathingActivity()
  {
    _name = "Breathing Activity";

    _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
  }

  public void Run()
  {
    DisplayStartingMessage();

    DateTime endTime = DateTime.Now.AddSeconds(_duration);

    bool breathIn = true;

    while (DateTime.Now <= endTime)
    {
      if (breathIn)
      {
        Console.WriteLine();

        Console.WriteLine();

        Console.Write("Breathe In...");

        ShowCountDown();

        Console.WriteLine();
      }
      else
      {
        Console.Write("Now breathe Out...");

        ShowCountDown();

        Console.WriteLine();

        Console.WriteLine();
      }
      breathIn = !breathIn;
    }
    DisplayEndingMessage();
  }
}