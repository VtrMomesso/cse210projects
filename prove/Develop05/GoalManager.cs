using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EternalQuest
{
    // Manager class for handling goals
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void Start()
        {
            // Initial display or setup code here if needed
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Score: {_score}");
        }

        public void ListGoalNames()
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.ShortName);
            }
        }

        public void ListGoalDetails()
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("Enter goal type (simple, checklist, eternal): ");
            string type = Console.ReadLine().ToLower();

            Console.WriteLine("Enter goal name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter goal description: ");
            string description = Console.ReadLine();

            Console.WriteLine("Enter goal points: ");
            int points = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "simple":
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "checklist":
                    Console.WriteLine("Enter target count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());

                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    break;
                case "eternal":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    break;
            }
        }

        public void RecordEvent()
        {
            Console.WriteLine("Enter goal name to record event: ");
            string name = Console.ReadLine();

            Goal goal = _goals.FirstOrDefault(g => g.ShortName == name);
            if (goal != null)
            {
                goal.RecordEvent();
                if (goal.IsComplete())
                {
                    _score += goal.Points;
                    if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
                    {
                        _score += checklistGoal.GetDetailsString().Split(',').Select(int.Parse).ToList()[4]; // bonus points
                    }
                }
                else
                {
                    _score += goal.Points;
                }
            }
            else
            {
                Console.WriteLine("Goal not found.");
            }
        }

        public void SaveGoals()
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
                writer.WriteLine($"Score:{_score}");
            }
        }

        public void LoadGoals()
        {
            if (!File.Exists("goals.txt"))
                return;

            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string type = parts[0];
                    string[] data = parts[1].Split(',');

                    switch (type)
                    {
                        case "SimpleGoal":
                            _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));
                            break;
                        case "ChecklistGoal":
                            _goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4])));
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                            break;
                    }
                }
                _score = int.Parse(reader.ReadLine().Split(':')[1]);
            }
        }
    }
}
