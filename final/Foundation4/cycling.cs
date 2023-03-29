public class Cycling:Activity{
    private float _speed;
    public Cycling(string date, float minutes, string activity, float speed):base(date,minutes,activity){
        _speed = speed;
    }
    public override float CalcDistance(){
        return _speed * base.Getmin();
    }

    
    public override float CalcSpeed(){
        return _speed;
    }
    public override float CalcPace(){
        return 60/_speed;
    }
    public override string Summary(){
        return $"{base.GetDate()} {base.Getact()}({base.Getmin()}min)-Distance {CalcDistance()} km, Speed {_speed} kph, Pace: {CalcPace()} per km";
    }
}