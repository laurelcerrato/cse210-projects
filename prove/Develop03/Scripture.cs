using System;
public class Scripture
{  
    private string _scripture = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life";
    private string _reference;
    public List<string> _wordList= new List<string>();
    public Scripture(){

    }
    public Scripture(string scripture )
    {   
        string[] array = scripture.Split(' ');
        foreach(string word in array){
            _wordList.Add(new Word (word).ToString());
        }
    }
        public int extractIndexFromScrip(){
        Random r = new Random();
        Scripture scrip = new Scripture(_scripture);
        int index = r.Next(scrip._wordList.Count());
        return index;
    }
    public void HideWord(){
        extractIndexFromScrip();
        // Word newword =new Word();
        // int word1 = extractIndexFromScrip();
        // int word2 = extractIndexFromScrip();
        // int word3 = extractIndexFromScrip();
        // string firstword = _wordList[word1];
        // string converted = _wordList[word1] = newword.hide(firstword);
        // string secword = _wordList[word2];
        // string secconverted = _wordList[word2] = newword.hide(secword);
        // string trword = _wordList[word3];
        // string trconverted = _wordList[word3] = newword.hide(trword);
    }
    public void RenderedText(){
        // Console.Clear();
        Console.WriteLine($"rend{_reference} {string.Join(" ",_wordList)}.");
        Console.WriteLine("Press enter to continue or type quit to finish");
    }
    public void DisplayComplScrip(){
        Console.WriteLine($"dis{_reference} {_scripture}.");
        Console.WriteLine("Press enter to continue or type quit to finish");
    }
    public void SetfinalRefer(string reference){
        _reference = reference;
        }
}

