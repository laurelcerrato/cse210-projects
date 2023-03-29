public class Swimming:Activity{

    private int _laps;
    public Swimming(string date, float minutes, string activity, int laps):base(date,minutes,activity){
        _laps = laps;
    }
    public override float CalcDistance(){
        return 1;
    }
    public override float CalcSpeed(){
        return 1;
    }
    public override float CalcPace(){
        return 1;
    }
}