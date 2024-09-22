using System;

class Program
{
  static void Main(string[] args)
  {
    List<int> numbers = new List<int>();

    int userNumber = -1;
    Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    while (userNumber != 0)
    {
      Console.Write("Enter number: ");

      string userResponse = Console.ReadLine();
      userNumber = int.Parse(userResponse);

      if (userNumber != 0)
      {
        numbers.Add(userNumber);
      }
    }
    int sum = 0;
    foreach (int number in numbers)
    {
      sum += number;
    }

    Console.WriteLine($"The sum is: {sum}");
    float average = ((float)sum) / numbers.Count;
    Console.WriteLine($"The average is: {average}");

    int max = numbers[0];

    foreach (int number in numbers)
    {
      if (number > max)
      {
        max = number;
      }
    }

    Console.WriteLine($"The largest number is: {max}");

    // stretch challenge
    int? smallestPositive = null;

    foreach (int num in numbers)
    {
      if (num > 0 && (smallestPositive == null || num < smallestPositive))
      {
        smallestPositive = num;
      }
    }

    if (smallestPositive != null)
    {
      Console.WriteLine($"The smallest positive number is: {smallestPositive}");
    }
    else
    {
      Console.WriteLine("There are no positive numbers in the list.");
    }

    // sort the list
    numbers.Sort();
    Console.WriteLine("The sorted list is:");
    foreach (int num in numbers)
    {
      Console.WriteLine(num + " ");
    }
    Console.WriteLine();

  }
}