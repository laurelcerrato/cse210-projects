public class Cycling:Activity{
    private int _speed;
    public Cycling(string date, float minutes, string activity, int speed):base(date,minutes,activity){
        _speed = speed;
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