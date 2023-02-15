using System;
public class Word
{
    private string _word;
    public List<int> _hiddenWords;
    public Word(){

    }
    public Word(string word){
        _word = word;
    }
    public void extractWord(Scripture scrip){
        int word1 = scrip.extractIndexFromScrip();
        int word2 = scrip.extractIndexFromScrip();
        int word3 = scrip.extractIndexFromScrip();
        _hiddenWords.Add(word1);
        _hiddenWords.Add(word2);
        _hiddenWords.Add(word3);
    }
    public void hide(string word){
            string w = word;
            int length = word.Length;
            string undersc = new String('_', length);
            Console.Write(undersc);
    }
    public void Show(){
        Console.Write(_word);
    }
}

