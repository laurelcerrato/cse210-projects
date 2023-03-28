public class Reception:Event{
    private string _rsvp;
    public Reception(string title, string description, string date, string time, string address, string type, string email):base(title,description,date,time,address,type){
        _rsvp = email;
    }
    public override void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"RSVP Email: {_rsvp}");
    }
}
