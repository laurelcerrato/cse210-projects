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
                Console.Write("The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich type of goal would you like to create? ");
                typeofgoal = int.Parse(Console.ReadLine());
                if(typeofgoal == 1){
                    Simple simplegoal = new Simple();
                    simplegoal.CreateSimpleGoal();
                    _goals.Add(simplegoal.OrganizedGoal());
                }
                else if(typeofgoal == 2){
                    Eternal eternalgoal = new Eternal();
                    eternalgoal.CreateEternalGoal();
                    _goals.Add(eternalgoal.OrganizedGoal());
                }
                else if(typeofgoal == 3){
                    Checklist checklistgoal = new Checklist();
                    checklistgoal.GoalInfo();
                    _goals.Add(checklistgoal.OrganizedGoal());
                }
                
            }
            else if(chosen == "2"){
                int count = 1;
                Console.WriteLine("The goals are: ");
                foreach( string goalItem in _goals)
                {
                    Console.WriteLine($"[ ] {count}. {goalItem}");
                    count ++;
                }
            }
        }
    }
}
