using System;
public class Reference
{
    private string _book = "Proverbs";
    private int _chapter = 3;
    private int _startverse = 5;
    private int _endverse = 6;
    public Reference(){

    }
    private Reference(int chapter, int verse)
    {
        chapter = _chapter;
        verse = _startverse;
        Console.Write($"{_book} {chapter}:{verse}");

    }
    private Reference(int chapter, int verse, int endverse)
    {
        chapter = _chapter;
        verse = _startverse;
        endverse = _endverse;
        Console.Write($"{_book} {chapter}:{verse}-{endverse}");
    }
    public void returnedReference(){
        Reference reference = new Reference(_chapter, _startverse, _endverse);
    }
}