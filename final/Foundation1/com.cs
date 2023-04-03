public class Comment{
    public string _name;
    public string _commentext;
    public Comment(string name, string commentext){
        _name = name;
        _commentext = commentext;
    }
    public string ReturnComment(){
        string comment = $"{_name}: {_commentext}";
        return comment;
    }
}