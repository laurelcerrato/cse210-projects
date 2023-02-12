using System;
public class Word
{
    public string _word;
    public string _convertedWord;
    public Word(){

    }
    public Word(string word){
        _word = word;
    }
    public void  returnedword(){
        hide(_word);
    }
    // public string GetWord(string word){
    //     _word = returnedword(word)
    // }
    public void hide(string word){

            foreach(char letter in word){
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