using System;

namespace EternalQuest
{
  class Program
  {
    static void Main(string[] args)
    {
      GoalManager goalManager = new GoalManager();
      bool exit = false;

      while (!exit)
      {
        Console.WriteLine("\n--- Goal Management Menu ---");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select an option (1-6): ");

        string choice = Console.ReadLine();
        switch (choice)
        {
          case "1":
            CreateGoal(goalManager);
            break;
          case "2":
            goalManager.DisplayGoals();
            break;
          case "3":
            SaveGoals(goalManager);
            break;
          case "4":
            LoadGoals(goalManager);
            break;
          case "5":
            RecordEvent(goalManager);
            break;
          case "6":
            exit = true;
            Console.WriteLine("Exiting the program...");
            break;
          default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
        }
      }
    }

    static void CreateGoal(GoalManager goalManager)
    {
      Console.WriteLine("\nChoose goal type to create:");
      Console.WriteLine("1. Simple Goal");
      Console.WriteLine("2. Eternal Goal");
      Console.WriteLine("3. Checklist Goal");
      Console.Write("Select an option (1-3): ");

      string goalType = Console.ReadLine();
      Console.Write("Enter goal name: ");
      string name = Console.ReadLine();
      Console.Write("Enter goal description: ");
      string description = Console.ReadLine();
      Console.Write("Enter points: ");
      int points = int.Parse(Console.ReadLine());

      switch (goalType)
      {
        case "1":
          goalManager.AddGoal(new SimpleGoal(name, description, points));
          Console.WriteLine("Simple Goal created.");
          break;
        case "2":
          goalManager.AddGoal(new EternalGoal(name, description, points));
          Console.WriteLine("Eternal Goal created.");
          break;
        case "3":
          Console.Write("Enter target number of completions: ");
          int target = int.Parse(Console.ReadLine());
          Console.Write("Enter bonus points: ");
          int bonus = int.Parse(Console.ReadLine());
          goalManager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
          Console.WriteLine("Checklist Goal created.");
          break;
        default:
          Console.WriteLine("Invalid goal type selected.");
          break;
      }
    }

    static void SaveGoals(GoalManager goalManager)
    {
      Console.Write("Enter file name to save goals: ");
      string fileName = Console.ReadLine();
      goalManager.SaveGoals(fileName);
      Console.WriteLine("Goals saved successfully.");
    }

    static void LoadGoals(GoalManager goalManager)
    {
      Console.Write("Enter file name to load goals: ");
      string fileName = Console.ReadLine();
      goalManager.LoadGoals(fileName);
      Console.WriteLine("Goals loaded successfully.");
    }

    static void RecordEvent(GoalManager goalManager)
    {
      Console.WriteLine("Select a goal to record an event:");
      goalManager.DisplayGoals();

      Console.Write("Enter goal number to record event for: ");
      int goalIndex = int.Parse(Console.ReadLine()) - 1;

      if (goalIndex >= 0 && goalIndex < goalManager.Goals.Count)
      {
        goalManager.RecordEvent(goalManager.Goals[goalIndex]);
        Console.WriteLine("Event recorded successfully.");
      }
      else
      {
        Console.WriteLine("Invalid goal number.");
      }
    }
  }
}
