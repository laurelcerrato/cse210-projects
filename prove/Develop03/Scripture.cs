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
        public string extractWord(){
        Scripture scrip = new Scripture(_scripture);
        Random r = new Random();
        string exword = scrip._wordList[r.Next(scrip._wordList.Length)];
        // Console.Write(exword);
        // Word changword = new Word();
        // changword.setWord();            
        //     changword.returnedword();
        // int index = r.Next(scrip._wordList.Length);
            // Console.WriteLine(scrip._wordList[index] = changword.returnedword());
        return exword;
    }
    // public void HiddenWord(){
    // }
    public void RenderedText(){
        Console.WriteLine($"{_reference} {_scripture}.");
        Console.WriteLine("Press enter to continue or type quit to finish");
    }
    public void SetfinalRefer(string reference){
        _reference = reference;
            }
} 