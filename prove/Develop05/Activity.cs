using System;

public class Activity
{
  protected string _name;

  protected string _description;

  protected int _duration;

  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Welcome to the {_name}\n");

    Console.WriteLine($"{_description}\n");

    Console.Write("How long, in seconds, would you like for your session? ");

    string res = Console.ReadLine();

    _duration = int.Parse(res);

    Console.Clear();

    Console.WriteLine("Get ready...");

    ShowSpinner(8);
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine("Well done!!\n");

    ShowSpinner(8);

    Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");

    ShowSpinner(8);
  }
  public void ShowSpinner(int seconds)
  {
    DateTime dateTime = DateTime.Now;

    DateTime endTime = dateTime.AddSeconds(seconds);

    List<string> animationaStrings = new List<string>();

    animationaStrings.Add("|");

    animationaStrings.Add("/");

    animationaStrings.Add("-");

    animationaStrings.Add("\\");

    animationaStrings.Add("|");

    animationaStrings.Add("/");

    animationaStrings.Add("-");

    animationaStrings.Add("\\");

    int i = 0;

    while (DateTime.Now < endTime)
    {
      string s = animationaStrings[i];

      Console.Write(s);

      Thread.Sleep(900);

      Console.Write("\b \b");

      i++;

      if (i >= animationaStrings.Count)
      {
        i = 0;
      }
    }
  }

  public void ShowCountDown()
  {
    for (int i = 5; i > 0; i--)
    {
      Console.Write(i);

      Thread.Sleep(1000);

      Console.Write("\b \b");
    }
  }
}