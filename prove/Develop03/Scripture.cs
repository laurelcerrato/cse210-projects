using System;
public class Scripture
{  
    private string _scripture = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life";
    private string _reference;
    private string[] _wordList;
    // public List<string> _wordList= new List<string>();
    public Scripture(){

    }
    Random r = new Random();
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
        public string extractWordFromScrip(){
        Scripture scrip = new Scripture(_scripture);
        string exword = scrip._wordList[r.Next(scrip._wordList.Length)];
        int index = r.Next(scrip._wordList.Length);
        Word changword = new Word();            
        string rword = changword.returnedword();
        _wordList[index] = rword;
        return exword;
    }
    // public void HidenWord(){
    //     Scripture scrip = new Scripture(_scripture);
    //     int index = r.Next(scrip._wordList.Length);
    //     string eword = extractWordFromScrip();
    //     Word changword = new Word();            
    //     string rword = changword.returnedword();
    //     _wordList[index] = rword;
    // }
    public void RenderedText(){
        string finalscrip = string.Join(",",_wordList);
        Console.WriteLine($"{_reference} {finalscrip}.");
        Console.WriteLine("Press enter to continue or type quit to finish");
    }
    public void SetfinalRefer(string reference){
        _reference = reference;
            }
} 