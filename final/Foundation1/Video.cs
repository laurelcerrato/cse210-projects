public class Video{
    public string _title;
    public string _author;

    public int _lenght;
    public List<Comment> _comments = new List<Comment>();

    public int Amount(List<Comment> list){
        return list.Count();
    }
    public void DisplayVideoInfo(){
        int commentsamount = Amount(_comments);
        Console.WriteLine($"\nVideo title: {_title}, Author: {_author}, {_lenght} minutes, Number Of Comments: {commentsamount}");
        foreach(Comment comment in _comments){
            Console.WriteLine(comment.ReturnComment());
        }
    }

}