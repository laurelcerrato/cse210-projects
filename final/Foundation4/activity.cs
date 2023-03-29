public class Activity{
    private string _date;
    private float _minutes;
    private string _activity;

    public Activity(string date, float minutes, string activity){
        _date = date;
        _minutes = minutes;
        _activity = activity;
    }
    public string GetDate(){
        return _date;
    }
    public float Getmin(){
        return _minutes;
    }
    public string Getact(){
        return _activity;
    }


    public virtual float CalcDistance(){
        return 1;
    }
    public virtual float CalcSpeed(){
        return 1;
    }
    public virtual float CalcPace(){
        return 1;
    }
    public virtual string Summary(){
        return $"";
    }
}