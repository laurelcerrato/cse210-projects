public class Event{
    private string _enttitle;
    private string _description;
    private string _date;
    private string _time;
    private string _type;
    private Address _address;

    
    public Event(string title, string description, string date, string time, Address address, string type){
        _enttitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }
    public void Standard(){
        Console.WriteLine($"Title:{_enttitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}");
    }
    //I decided to used polymorphism for this method because in this way it would make the use of it easier for each type of event
    public virtual void FullDetails(){
        Standard();
        Console.WriteLine(_type);
    }
    public void Short(){
        Console.WriteLine($"{_type}\n{_enttitle}\n{_date}");
    }
}