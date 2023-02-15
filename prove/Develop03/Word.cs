using System;
public class Word
{
    private string _word;
    public Word(){

    }
    public Word(string word){
        _word = word;
    }

    public string hide(string word){
            int length = word.Length;
            string convertedWord = new String('_', length);
    return convertedWord;
    }
}