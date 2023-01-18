public class resume
{
    public string _name= "";
    public List<Job> _jobTitle = new List<Job> ();

    public void displayJobs()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        foreach ( Job job in _jobTitle) 
            job.display();
    }
}    