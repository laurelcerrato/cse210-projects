using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)

    {   
        Goal goal = new Goal();
        int points = goal.GetScore();
        int typeofgoal = goal.GetGoaltype();
        List<string> _goals = new List<string>();
        List<string> _filegoals = new List<string>();

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
                    _goals.Add(simplegoal.listGoal());
                    _filegoals.Add(simplegoal.fileGoal());
                }
                else if(typeofgoal == 2){
                    Eternal eternalgoal = new Eternal();
                    eternalgoal.CreateEternalGoal();
                    _goals.Add(eternalgoal.listGoal());
                    _filegoals.Add(eternalgoal.fileGoal());
                }
                else if(typeofgoal == 3){
                    Checklist checklistgoal = new Checklist();
                    checklistgoal.GoalInfo();
                    _goals.Add(checklistgoal.listGoal());
                    _filegoals.Add(checklistgoal.fileGoal());
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
            else if(chosen == "3"){
                Console.Write("What is the name for the filename? ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    // You can add text to the file with the WriteLine method
                    outputFile.WriteLine(points);
                    foreach(string goalItem in _filegoals){
                        outputFile.WriteLine(goalItem );
                    }
            }
            }
            else if(chosen == "4"){
                Console.Write("Please write the file name from were you want to load the goals: ");
                string loadFile = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(loadFile);
                lines = lines.Skip(1).ToArray();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    string goaltype = parts[0];
                    string goalname = parts[1];
                    string goaldescrip = parts[2];
                    int goalpoints = int.Parse(parts[3]);
                    if(goaltype == "Simple"){
                        Simple simplefile = new Simple();
                        simplefile.SetName(goalname);
                        simplefile.SetDescription(goaldescrip);
                        simplefile.SetGoalPoints(goalpoints);
                        _goals.Add(simplefile.listGoal());

                    }
                    else if(goaltype == "Eternal"){
                        Eternal eternalfile = new Eternal();
                        eternalfile.SetName(goalname);
                        eternalfile.SetDescription(goaldescrip);
                        eternalfile.SetGoalPoints(goalpoints);
                        _goals.Add(eternalfile.listGoal());

                    }
                    else if(goaltype == "Checklist"){
                        int timestocom = int.Parse(parts[4]);
                        int timescompleted = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        Checklist checklistfile = new Checklist();
                        checklistfile.SetName(goalname);
                        checklistfile.SetDescription(goaldescrip);
                        checklistfile.SetGoalPoints(goalpoints);
                        checklistfile.Setbonuspoints(bonus);
                        _goals.Add(checklistfile.listGoal());
                    }
                }
            }
        }
    }
}
