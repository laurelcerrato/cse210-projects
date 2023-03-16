using System;

class Program
{
    static void Main(string[] args)

    {   
        Goal goal = new Goal();
        int points = goal.GetScore();
        int typeofgoal = goal.GetGoaltype();
        List<string> _goals = new List<string>();

        string chosen = "";

        while(chosen != "6"){
            Console.WriteLine($"Your score is : {points}\n");
            Console.WriteLine($"Menu options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("Select a choice from the Menu: ");
            chosen = Console.ReadLine();

            if (chosen == "1"){
                Console.WriteLine("The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich type of goal would you like to create? ");
                typeofgoal = int.Parse(Console.ReadLine());
                if(typeofgoal == 1){
                    Simple simplegoal = new Simple();
                    simplegoal.CreateSimpleGoal();
                }
                else if(typeofgoal == 2){
                    Eternal eternalgoal = new Eternal();
                    eternalgoal.CreateEternalGoal();
                }
                else if(typeofgoal == 3){
                    Checklist checklistgoal = new Checklist();
                    checklistgoal.GoalInfo();
                }
                
            }
            else if(chosen == "2"){
                goal.ListGoals();
            }
        }
    }
}
