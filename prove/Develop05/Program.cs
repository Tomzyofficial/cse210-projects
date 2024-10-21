// I exceeded requirement by providing another menu to allow 
// users to reflect on things they are grateful for in their life.

using System;

class Program
{
  static void Main(string[] args)
  {
    while (true)
    {
      Console.Clear();

      Console.WriteLine("Menu Options");

      Console.WriteLine("1. Start breathing activity");

      Console.WriteLine("2. Start reflecting activity");

      Console.WriteLine("3. Start listing activity");

      Console.WriteLine("4. Gratitude activity ");

      Console.WriteLine("5. Quit");

      Console.Write("Select a choice from the menu: ");

      string res = Console.ReadLine();

      int result = int.Parse(res);

      if (result == 1)
      {
        Console.Clear();

        BreathingActivity breathingActivity = new BreathingActivity();

        breathingActivity.Run();
      }
      else if (result == 2)
      {
        Console.Clear();

        ReflectingActivity reflectingActivity = new ReflectingActivity();

        reflectingActivity.Run();
      }
      else if (result == 3)
      {
        Console.Clear();

        ListingActivity listingActivity = new ListingActivity();

        listingActivity.Run();
      }
      else if (result == 4)
      {
        Console.Clear();

        GratitudeActivity gratitudeActivity = new GratitudeActivity();

        gratitudeActivity.Run();
      }
      else if (result == 5)
      {
        break;
      }
      else
      {
        Console.WriteLine("You have selected a wrong menu. Try again.");
      }
    }
  }
}