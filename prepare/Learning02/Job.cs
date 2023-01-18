public class Job
{
    public string _company;
    public string _jobs;
    public int _startYear;
    public int _endYear;

    public void display()
    {
        Console.WriteLine($"{_jobs} ({_company}) {_startYear}-{_endYear}");
    }
}
