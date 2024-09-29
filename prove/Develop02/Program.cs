// I exceeded by making sure the journal can be saved in a separate file
// I also worked with the dateTime to enable me get the user's actual date and time
// Added some texts to let the user know the status of their journal

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    Journal journal = new Journal();
    bool running = true;

    // Continue looping as long as running is true
    while (running)
    {
      Console.WriteLine("Welcome to the Journal Program!");
      Console.WriteLine("Please select one of the following choices:");
      Console.WriteLine("1. Write");
      Console.WriteLine("2. Display");
      Console.WriteLine("3. Load");
      Console.WriteLine("4. Save");
      Console.WriteLine("5. Quit");
      Console.Write("What would you like to do? ");
      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          journal.AddEntry();
          break;
        case "2":
          journal.DisplayJournal();
          break;
        case "3":
          Console.WriteLine("What is the filename?");
          string loadFilename = Console.ReadLine();
          journal.LoadJournal(loadFilename);
          break;
        case "4":
          Console.WriteLine("What is the filename?");
          string saveFilename = Console.ReadLine();
          journal.SaveJournal(saveFilename);
          break;
        case "5":
          // running is set to false and program ends here
          running = false;
          Console.WriteLine("Goodbye!");
          break;
        default:
          Console.WriteLine("Invalid option. Please try again.");
          break;
      }
    }
  }
}
