using System;
public class Word
{
    private string _word;
    private string _convertedWord;
    public Word(){

    }
    public Word(string word){
        Scripture exword = new Scripture();
        _word = exword.extractWordFromScrip();
    }
    public string  returnedword(){
        hide(_word);
        return _convertedWord;

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
    // public void setWord(){
    //     Scripture word = new Scripture();
    //     _word = word.extractWordFromScrip();
    //     Console.WriteLine(_word);
    // }
}