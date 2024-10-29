using System;
using System.Collections.Generic;
class Program
{
  static void Main(string[] args)
  {
    List<Activity> activities = new List<Activity>
      {
        new Running(30, "03 Nov 2022", 3.0),
        new Cycling(30, "03 Nov 2022", 12.0),
        new Swimming(30, "03 Nov 2022", 20)
      };

    foreach (Activity activity in activities)
    {
      Console.WriteLine(activity.GetSummary());
    }
  }
}