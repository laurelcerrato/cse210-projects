using System;
public class Word
{
    private string _word;

    public Word(string word){
        _word = word;
        hide(_word);
    }
    public void hide(string word){

        // foreach (string word in _word){
            foreach(char letter in _word){
                string stringedlet = Char.ToString(letter);
                string replacement = "_";
                char converted = char.Parse(replacement);
                Console.Write(stringedlet.Replace(letter,converted));
            }
        // }
    }
}