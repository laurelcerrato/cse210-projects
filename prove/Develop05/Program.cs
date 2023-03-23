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
        List<Goal> _goals = new List<Goal>();
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
                    _goals.Add(simplegoal);
                    _filegoals.Add(simplegoal.fileGoal());
                }
                else if(typeofgoal == 2){
                    Eternal eternalgoal = new Eternal();
                    eternalgoal.CreateEternalGoal();
                    _goals.Add(eternalgoal);
                    _filegoals.Add(eternalgoal.fileGoal());
                }
                else if(typeofgoal == 3){
                    Checklist checklistgoal = new Checklist();
                    checklistgoal.GoalInfo();
                    _goals.Add(checklistgoal);
                    _filegoals.Add(checklistgoal.fileGoal());
                }
                
            }
            else if(chosen == "2"){
                int count = 1;
                Console.WriteLine("The goals are: ");
                foreach( Goal goalItem in _goals)
                {
                    string goalText = goalItem.GetGoal();
                    Console.WriteLine($"{count}. {goalText}");
                    count ++;
                }
            }
            else if(chosen == "3"){
                Console.Write("What is the name for the filename? ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(points);
                    foreach(Goal goalItem in _goals){
                        string goalText = goalItem.fileGoal();
                        outputFile.WriteLine(goalText);
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
                        simplefile.SetCompleted();
                        _goals.Add(simplefile);

                    }
                    else if(goaltype == "Eternal"){
                        Eternal eternalfile = new Eternal();
                        eternalfile.SetName(goalname);
                        eternalfile.SetDescription(goaldescrip);
                        eternalfile.SetGoalPoints(goalpoints);
                        eternalfile.SetCompleted();
                        _goals.Add(eternalfile);

                    }
                    else if(goaltype == "Checklist"){
                        int timestocom = int.Parse(parts[5]);
                        int timescompleted = int.Parse(parts[6]);
                        int bonus = int.Parse(parts[4]);
                        Checklist checklistfile = new Checklist();
                        checklistfile.SetName(goalname);
                        checklistfile.SetDescription(goaldescrip);
                        checklistfile.SetGoalPoints(goalpoints);
                        checklistfile.Setbonuspoints(bonus);
                        checklistfile.SetTimescompleted(timescompleted);
                        checklistfile.SetTimestocomplete(timestocom);
                        checklistfile.SetCompleted();
                        _goals.Add(checklistfile);
                    }
                }
            }
            else if (chosen == "5"){
                int count = 1;
                Console.WriteLine("The goals are: ");
                foreach( Goal goalItem in _goals)
                {
                    Console.WriteLine($"{count}. {goalItem.GetName()}");
                    count ++;
                }
                Console.Write("Which goal did you accomplished? ");
                int accomplishedgoal = int.Parse(Console.ReadLine());
                int goalIndex = accomplishedgoal-1;
                Console.WriteLine(_goals[goalIndex].SetCompleted());
            }
        }
    }
}
