using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("What is your grade percentage? ");
    string answer = Console.ReadLine();
    int percent = int.Parse(answer);

    string letter = "";
    string sign = "";

    if (percent >= 90)
    {
      letter = "A";
    }
    else if (percent >= 80)
    {
      letter = "B";
    }
    else if (percent >= 70)
    {
      letter = "C";
    }
    else if (percent >= 60)
    {
      letter = "D";
    }
    else
    {
      letter = "F";
    }

    // stretch challenge
    if (letter != "A" && letter != "F")
    {
      int lastNum = percent % 10;
      if (lastNum >= 7)
      {
        sign = "+";
      }
      else if (lastNum < 3)
      {
        sign = "-";
      }
      else
      {
        sign = "";
      }
    }

    if (letter == "A" && percent >= 90 && percent < 93)
    {
      sign = "-";
    }

    if (letter == "F")
    {
      sign = "";
    }


    Console.WriteLine($"Your grade is: {letter}{sign}");

    if (percent >= 70)
    {
      Console.WriteLine("You passed!");
    }
    else
    {
      Console.WriteLine("Better luck next time!");
    }
  }
}