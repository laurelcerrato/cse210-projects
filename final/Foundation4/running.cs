public class Running:Activity{
    private float _distance;
    public Running(string date, float minutes, string activity,float distance):base(date,minutes,activity){
        _distance = distance;
    }
    public override float CalcDistance(){
        return _distance;
    }

    
    public override float CalcSpeed(){
        float speed = (_distance/base.Getmin()) * 60;
        return speed;
    }
    public override float CalcPace(){
        return base.Getmin()/_distance;
    }
    public override string Summary(){
        return $"{base.GetDate()} {base.Getact()}({base.Getmin()}min)-Distance {_distance} km, Speed {CalcSpeed()} kph, Pace: {CalcPace()} per km";
    }
}