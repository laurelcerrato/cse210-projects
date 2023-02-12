using System;
public class Word
{
    private string _word;
    private string _convertedWord;
    public Word(){

    }
    public Word(string word){
        _word = word;
    }
    public string  returnedword(){
        hide();
        return _convertedWord;

    }
    // public string GetWord(string word){
    //     _word = returnedword(word)
    // }
    public void hide(){

            foreach(char letter in _word){
                string stringedlet = Char.ToString(letter);
                string replacement = "_";
                char converted = char.Parse(replacement);
                _convertedWord = stringedlet.Replace(letter,converted);
                Console.Write(_convertedWord);
            }

    }
    public void setWord(){
        Scripture word = new Scripture();
        _word = word.extractWord();
        Console.WriteLine(_word);


    }
}