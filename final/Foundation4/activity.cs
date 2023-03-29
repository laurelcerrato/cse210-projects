public class Activity{
    private string _date;
    private float _minutes;
    private string _activity;

    public Activity(string date, float minutes, string activity){
        _date = date;
        _minutes = minutes;
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
    public string Summary(){
        return $"";
    }
}