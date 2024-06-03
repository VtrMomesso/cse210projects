using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager goalManager = new GoalManager();
            goalManager.Start();

            bool running = true;
            while (running)
            {
                Console.WriteLine("1. Display Player Info");
                Console.WriteLine("2. List Goal Names");
                Console.WriteLine("3. List Goal Details");
                Console.WriteLine("4. Create Goal");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Save Goals");
                Console.WriteLine("7. Load Goals");
                Console.WriteLine("8. Exit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        goalManager.DisplayPlayerInfo();
                        break;
                    case "2":
                        goalManager.ListGoalNames();
                        break;
                    case "3":
                        goalManager.ListGoalDetails();
                        break;
                    case "4":
                        goalManager.CreateGoal();
                        break;
                    case "5":
                        goalManager.RecordEvent();
                        break;
                    case "6":
                        goalManager.SaveGoals();
                        break;
                    case "7":
                        goalManager.LoadGoals();
                        break;
                    case "8":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
