
public class GoalManager
{
    private static List<Goal> goals = new List<Goal>();
    private static int userScore = 0;

    public static void Main()
    {
        while (true)
        {
            DisplayMenu();
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    DisplayGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine($"You have {userScore} points\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create a New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    private static void CreateGoal()
    {
        Console.WriteLine("Which type of goal would you like to create?");
        Console.WriteLine("  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
        int typeChoice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal?");
        int points = Convert.ToInt32(Console.ReadLine());

        Goal newGoal = typeChoice switch
        {
            1 => new SimpleGoal(name, description, points),
            2 => new EternalGoal(name, description, points),
            3 => CreateChecklistGoal(name, description, points),
            _ => null
        };

        if (newGoal != null)
        {
            goals.Add(newGoal);
            Console.WriteLine("Goal created!");
        }
    }

    private static ChecklistGoal CreateChecklistGoal(string name, string description, int points)
    {
        Console.WriteLine("What is the target amount for this checklist goal?");
        int target = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the bonus points for completing this goal?");
        int bonus = Convert.ToInt32(Console.ReadLine());
        return new ChecklistGoal(name, description, points, target, bonus);
    }

    private static void DisplayGoals()
    {
        Console.WriteLine("\nList of Goals:");
        foreach (Goal goal in goals)
        {
            string status = goal is SimpleGoal simpleGoal && simpleGoal.IsComplete ? "Completed" : "Not Completed";
            Console.WriteLine($"{goal.ShortName} - {goal.Description} - Status: {status}");
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"Progress: {checklistGoal.AmountCompleted}/{checklistGoal.Target}");
            }
        }
    }

    private static void RecordEvent()
    {
        Console.WriteLine("Enter the name of the goal you completed:");
        string goalName = Console.ReadLine();

        Goal goal = goals.Find(g => g.ShortName == goalName);

        if (goal != null)
        {
            goal.MarkCompleted();
            userScore += goal.Points;
            Console.WriteLine($"Event recorded! You gained {goal.Points} points.");
        }
        else
        {
            Console.WriteLine("Goal not found!");
        }
    }

    private static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.ShortName},{goal.Description},{goal.Points}");
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{checklistGoal.Target},{checklistGoal.AmountCompleted},{checklistGoal.Bonus}");
                }
            }
            writer.WriteLine(userScore);
        }
    }

    private static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 4)
                    {
                        Goal goal = parts[0] switch
                        {
                            "SimpleGoal" => new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3])),
                            "EternalGoal" => new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3])),
                            "ChecklistGoal" => new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), 0, 0),
                            _ => null
                        };

                        if (goal != null)
                        {
                            if (goal is ChecklistGoal checklistGoal && parts.Length >= 6)
                            {
                                checklistGoal.SetProgress(Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]));
                            }

                            goals.Add(goal);
                        }
                    }
                }

                if (int.TryParse(reader.ReadLine(), out int score))
                {
                    userScore = score;
                }
            }
        }

    }
}