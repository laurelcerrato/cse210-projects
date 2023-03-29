public class Swimming:Activity{

    private int _laps;
    public Swimming(string date, float minutes, string activity, int laps):base(date,minutes,activity){
        _laps = laps;
    }
    public override float CalcDistance(){
        return _laps * 50 / 1000;
    }

    
    public override float CalcSpeed(){
        return (CalcDistance()/ base.Getmin()) * 60;
    }
    public override float CalcPace(){
        return base.Getmin()/ CalcDistance();
    }
    public override string Summary(){
        return $"{base.GetDate()} {base.Getact()}({base.Getmin()}min)-Distance {CalcDistance()} km, Speed {CalcSpeed()} kph, Pace: {CalcPace()} per km";
    }
}