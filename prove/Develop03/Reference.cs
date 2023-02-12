using System;
public class Reference
{
    private string _book = "Proverbs";
    private int _chapter = 3;
    private int _startverse = 5;
    private int _endverse = 6;
    // private string _finalReference;
    public Reference(){

    }
    private Reference(int chapter, int verse)
    {
        chapter = _chapter;
        verse = _startverse;

    }
    public Reference(int chapter, int verse, int endverse)
    {
        chapter = _chapter;
        verse = _startverse;
        endverse = _endverse;
    }
    public string GetMultVReference(){
        string reference = $"{_book} {_chapter}:{_startverse}-{_endverse}";
        return reference;
    }
    public string GetoneVReference(){
        string onevreference = $"{_book} {_chapter}:{_startverse}";
        return onevreference;
    }
    
}