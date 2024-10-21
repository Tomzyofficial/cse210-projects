using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
  private List<string> _prompts = new List<string>
  {
    "--- Who are people that you appreciate? ---",

    "--- What are personal strengths of yours? ---",

    "--- Who are people that you have helped this week? ---",

    "--- When have you felt the Holy Ghost this month? ---",

    "--- Who are some of your personal heroes? ---"
  };

  public ListingActivity()
  {
    _name = "Listing Activity";

    _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
  }

  public void Run()
  {
    DisplayStartingMessage();

    Console.WriteLine();

    Console.WriteLine("List as many response you can to the following prompt:");

    Random random = new Random();

    Console.WriteLine(_prompts[random.Next(_prompts.Count)]);

    Console.Write("You may begin in: ");

    ShowCountDown();

    Console.WriteLine();

    List<string> listItems = new List<string>();

    DateTime endTime = DateTime.Now.AddSeconds(_duration);

    while (DateTime.Now <= endTime)
    {
      Console.Write("> ");

      string res = Console.ReadLine();

      listItems.Add(res);
    }
    Console.WriteLine($"You listed {listItems.Count} items\n");

    DisplayEndingMessage();
  }
}