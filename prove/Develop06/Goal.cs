using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
  // Base class for Goal
  abstract class Goal
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    public Goal(string name, string description, int points)
    {
      Name = name;
      Description = description;
      Points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString() => $"{Name}: {Description} - {Points} points";
    public abstract string GetStringRepresentation();
  }

  // SimpleGoal class
  class SimpleGoal : Goal
  {
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
      _isComplete = false;
    }

    public override void RecordEvent()
    {
      _isComplete = true;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStringRepresentation() => $"SimpleGoal,{Name},{Description},{Points},{_isComplete}";
  }

  // EternalGoal class
  class EternalGoal : Goal
  {
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent() { /* No completion logic for eternal goals */ }

    public override bool IsComplete() => false;

    public override string GetStringRepresentation() => $"EternalGoal,{Name},{Description},{Points}";
  }

  // ChecklistGoal class
  class ChecklistGoal : Goal
  {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
      _target = target;
      _bonus = bonus;
      _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
      _amountCompleted++;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString() => $"{Name}: {Description} - {Points} points each, Bonus: {_bonus} points on completion ({_amountCompleted}/{_target} completed)";

    public override string GetStringRepresentation() => $"ChecklistGoal,{Name},{Description},{Points},{_amountCompleted},{_target},{_bonus}";
  }

  // GoalManager class
  class GoalManager
  {
    public List<Goal> Goals { get; private set; } = new List<Goal>();
    public int Score { get; private set; } = 0;

    public void AddGoal(Goal goal)
    {
      Goals.Add(goal);
    }

    public void DisplayGoals()
    {
      for (int i = 0; i < Goals.Count; i++)
      {
        Console.WriteLine($"{i + 1}. [{(Goals[i].IsComplete() ? "X" : " ")}] {Goals[i].GetDetailsString()}");
      }
    }

    public void RecordEvent(Goal goal)
    {
      goal.RecordEvent();
      Score += goal.Points;
      if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
      {
        Score += checklistGoal.Points; // Bonus points
      }
    }

    public void SaveGoals(string fileName)
    {
      using StreamWriter writer = new StreamWriter(fileName);
      writer.WriteLine(Score);
      foreach (Goal goal in Goals)
      {
        writer.WriteLine(goal.GetStringRepresentation());
      }
    }

    public void LoadGoals(string fileName)
    {
      Goals.Clear();
      using StreamReader reader = new StreamReader(fileName);
      Score = int.Parse(reader.ReadLine());
      string line;
      while ((line = reader.ReadLine()) != null)
      {
        var parts = line.Split(',');
        switch (parts[0])
        {
          case "SimpleGoal":
            var simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
            simpleGoal.RecordEvent();  // Load completion status
            Goals.Add(simpleGoal);
            break;
          case "EternalGoal":
            Goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            break;
          case "ChecklistGoal":
            var checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
            Goals.Add(checklistGoal);
            break;
        }
      }
    }
  }
}
