public class Comment{
    public string _name;
    public string _commentext;
    
    public string ReturnComment(){
        string comment = $"{_name}: {_commentext}";
        return comment;
    }
}