public class Video{
    public string _title;
    public string _author;

    public int _lenght;

    public Video(string title, string author, int lenght){
        _title = title;
        _author = author;
        _lenght = lenght;
    }
    public List<Comment> _comments = new List<Comment>();

    public int Amount(List<Comment> list){
        return list.Count();
    }
    public void DisplayVideoInfo(){
        int commentsamount = Amount(_comments);
        Console.WriteLine($"\nVideo title: {_title}, Author: {_author}, {_lenght} minutes, Number Of Comments: {commentsamount}");
        Console.WriteLine("Comments:");
        foreach(Comment comment in _comments){
            Console.WriteLine(comment.ReturnComment());
        }
    }

}