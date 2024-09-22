using System;

class Program
{
  static void Main(string[] args)
  {
    string displayText = "";
    // part 1 and 2
    // Console.Write("What is the magic number? ");
    // int magicNum = int.Parse(Console.ReadLine());

    // part 3
    Random randomGenerator = new Random();
    int magicNum = randomGenerator.Next(1, 101);
    int guess = -1;

    // stretch challenge
    int count = 0;


    while (guess != magicNum)
    {
      Console.Write("What is your guess? ");
      guess = int.Parse(Console.ReadLine());
      if (guess > magicNum)
      {
        displayText = "Lower";
        count++;
      }
      else if (guess < magicNum)
      {
        displayText = "Higher";
        count++;
      }
      else
      {
        displayText = "You guessed it!";
      }
      Console.WriteLine(displayText);
    }
    Console.WriteLine($"You played {count} times!");
  }
}