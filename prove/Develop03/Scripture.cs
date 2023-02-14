using System;
public class Scripture
{  
    private string _scripture = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life";
    private string _reference;
    private string[] _wordList;
    // public List<string> _wordList= new List<string>();
    public Scripture(){

    }
    public Scripture(string scripture )
    {
        // string[] splittedscrip = scripture.Split(" ");
        _wordList = scripture.Split(' ');
    }
        // foreach (string stringInArray in _splittedStringArray) {
        //     _word.Add(stringInArray);
        //     foreach(string w in _word){
        //         Console.WriteLine(w);
        //     }
        // }
        // foreach (var words in splittedscrip) {
        // _word.Add(words);
        // foreach(var word in splittedscrip){
        //     Console.WriteLine(word);
        // }
        // }
        public int extractIndexFromScrip(){
        Scripture scrip = new Scripture(_scripture);
        Random r = new Random();
        int index = r.Next(scrip._wordList.Length);
        return index;
    }
    public void HideWord(){
        Word newword =new Word();
        Scripture scrip = new Scripture(_scripture);
        int word1 = extractIndexFromScrip();
        int word2 = extractIndexFromScrip();
        string firstword = scrip._wordList[word1];
        string converted = scrip._wordList[word1] = newword.hide(firstword);
        string secword = scrip._wordList[word2];
        string secconverted = scrip._wordList[word2] = newword.hide(secword);
        Console.WriteLine(string.Join(' ', scrip._wordList));
        // word1.ToString();
        // string converted = newword.hide(word1);
        // newword.hide(word1);
        // word1 = 
    }
    // public void RenderedText(){
    //     Scripture scrip = new Scripture(_scripture);
    //     scrip.HideWord();
    //     Console.WriteLine($"{_reference} {_wordList}.");
    //     Console.WriteLine("Press enter to continue or type quit to finish");
    // }
    public void SetfinalRefer(string reference){
        _reference = reference;
            }
} 
