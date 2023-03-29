public class Running:Activity{
    private int _distance;
    public Running(string date, float minutes, string activity,int distance):base(date,minutes,activity){
        _distance = distance;
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