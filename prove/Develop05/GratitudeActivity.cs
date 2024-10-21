using System;
public class GratitudeActivity : Activity
{
  public GratitudeActivity()
  {
    _name = "Gratitude Activity";

    _description = "This activity will help you reflect on things you are grateful for in your life.";
  }

  public void Run()
  {
    DisplayStartingMessage();

    DateTime endTime = DateTime.Now.AddSeconds(_duration);

    List<string> gratitudeItems = new List<string>();

    Console.WriteLine("Start listing things you're grateful for:");

    while (DateTime.Now <= endTime)
    {
      Console.Write("Enter a gratitude item: ");

      string item = Console.ReadLine();

      gratitudeItems.Add(item);
    }
    Console.WriteLine($"You listed {gratitudeItems.Count} things you're grateful for.\n");

    DisplayEndingMessage();
  }
}