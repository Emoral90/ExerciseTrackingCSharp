using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create activities
        Activity running = new Running(new DateTime(2022, 11, 3), 30, 4.8);
        Activity cycling = new Cycling(new DateTime(2022, 11, 4), 45, 20.0);
        Activity swimming = new Swimming(new DateTime(2022, 11, 5), 60, 30);

        // Add activities to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display summaries for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
