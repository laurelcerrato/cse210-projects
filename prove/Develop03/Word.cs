using System;
public class Word
{
    private string _word;
    private string _convertedWord;
    public List<string> _hiddenWords;
    public Word(){

    }
    // public Word(string word){
    //     Scripture exword = new Scripture();
    //     _word = exword.extractWordFromScrip();
    //     returnedword();
    // }
    // public string  returnedword(){
    //     hide(_word);
    //     return _convertedWord;
    
    // public string GetWord(string word){
    //     _word = returnedword(word)
    // }
    public string hide(string word){
            var str = word;
            int length = word.Length;
            string undersc = new String('_', length);
            return undersc;
            // foreach(char letter in word){
            //     string stringedlet = Char.ToString(letter);
            //     string replacement = "_";
            //     char converted = char.Parse(replacement);
            //     _convertedWord = stringedlet.Replace(letter,converted);
            //     Console.Write(_convertedWord);
            // }

    }
}

