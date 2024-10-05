// I randomly hid words that are not yet hidden 
using System;
using System.Collections.Generic;


class Program
{
  static void Main(string[] args)
  {
    // Example scripture
    Reference reference = new Reference("Proverbs", 3, 5, 6);
    Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

    while (true)
    {
      // Clear the console and display the scripture
      Console.Clear();
      scripture.Display();

      // Check if all words are hidden, if so, end the program
      if (scripture.AllWordsHidden())
      {
        Console.WriteLine("Hooray! You have memorized the scripture!");
        break;
      }

      // Prompt the user
      Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
      string userInput = Console.ReadLine();

      if (userInput.ToLower() == "quit")
      {
        break;
      }

      // Hide more words
      scripture.HideRandomWords();
    }
  }
}
