using System;
class Journal
{
  private List<Entry> _entries = new List<Entry>();
  private static List<string> _prompts = new List<string>
  {
    // list of prompts
    "Why were you angry and irritated today?",
    "At what stage of your life did you realize that you needed God?",
    "What meal did you have for breakfast?",
    "What was the best thing that was said to you today?",
    "If you had one wish to make, what would it be?"
  };

  public void AddEntry()
  {
    Random random = new Random();
    string randomPrompt = _prompts[random.Next(_prompts.Count)];
    Console.WriteLine(randomPrompt);
    Console.Write("> ");
    string response = Console.ReadLine();

    Entry newEntry = new Entry(randomPrompt, response);
    _entries.Add(newEntry);
    Console.WriteLine("Entry added!\n");
  }

  public void DisplayJournal()
  {
    if (_entries.Count == 0)
    {
      Console.WriteLine("No entries in the journal.");
    }
    else
    {
      foreach (var entry in _entries)
      {
        entry.Display();
      }
    }
  }

  public void SaveJournal(string filename)
  {
    using (StreamWriter writer = new StreamWriter(filename))
    {
      foreach (var entry in _entries)
      {
        writer.WriteLine(entry.Date);
        writer.WriteLine(entry.Prompt);
        writer.WriteLine(entry.Response);
        writer.WriteLine("-----");
      }
    }
    Console.WriteLine($"Journal saved to {filename}\n");
  }

  public void LoadJournal(string filename)
  {
    if (!File.Exists(filename))
    {
      Console.WriteLine("File not found.\n");
      return;
    }

    _entries.Clear();

    string[] lines = File.ReadAllLines(filename);
    for (int i = 0; i < lines.Length; i += 4)
    {
      DateTime date = DateTime.Parse(lines[i]);
      string prompt = lines[i + 1];
      string response = lines[i + 2];
      _entries.Add(new Entry(prompt, response) { Date = date });
    }

    Console.WriteLine($"Journal loaded from {filename}\n");
  }
}