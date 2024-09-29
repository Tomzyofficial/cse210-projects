using System;
class Entry
{
  public string Prompt
  {
    get; set;
  }
  public string Response
  {
    get; set;
  }
  public DateTime Date
  {
    get; set;
  }

  public Entry(string prompt, string response)
  {
    Prompt = prompt;
    Response = response;
    Date = DateTime.Now;
  }

  public void Display()
  {
    Console.WriteLine($"{Date.ToString("MM/dd/yyyy")}: {Prompt}");
    Console.WriteLine(Response);
    Console.WriteLine();
  }
}