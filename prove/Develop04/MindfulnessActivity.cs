using System;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class MindfulnessActivity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        public void StartActivity()
        {
            Console.WriteLine($"Starting {Name}");
            Console.WriteLine(Description);
            Console.WriteLine("Enter the duration of the activity in seconds:");
            Duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(3);
        }

        public void EndActivity()
        {
            Console.WriteLine("Good job!");
            Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
            ShowSpinner(3);
        }

        protected void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        public abstract void PerformActivity();
    }
}
