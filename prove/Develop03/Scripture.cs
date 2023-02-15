using System;
using Microsoft.VisualBasic.FileIO;
public class Scripture
{  
    private string _scripture = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life";
    private string _reference;
    private string[] _wordList;   
    private List<int> _hiddenWords = new List<int>();
    public Scripture(){
    }
    public Scripture(string scripture ){

        _wordList = scripture.Split(' ');
    }
    public int extractIndexFromScrip(){
        Random r = new Random();
        Scripture scrip = new Scripture(_scripture);
        int index = r.Next(scrip._wordList.Length);
        _wordList = scrip._wordList;
        return index;
    }
    public void setwords(){
        int index =extractIndexFromScrip();
        int index2 =extractIndexFromScrip();
        int index3 =extractIndexFromScrip();
        if (_hiddenWords.Contains(index) || _hiddenWords.Contains(index2) ||  _hiddenWords.Contains(index3)){
        if(_hiddenWords.Count< _wordList.Length+1){
            setwords();
            }else{
                //---CREATIVITY---
                Console.WriteLine("Well Done!\nTo verify you have succcesfully memorized the scripture please write it: ");
                string scripture = Console.ReadLine();
                if (scripture.ToLower() == _scripture.ToLower()){
                    Console.WriteLine("Perfect! You succesfully memorized the scripture.");
                }else{
                Console.WriteLine($"That is wrong :(\nThe complete scripture was:\n{_reference} {_scripture}.");}
                System.Environment.Exit(1);
            }
        }
        else
        {
            _hiddenWords.Add(index);
            _hiddenWords.Add(index2);
            _hiddenWords.Add(index3);

        }
    }
    public void finalText(){
        Console.Write($"{_reference} ");
        for (int i = 0; i < _wordList.Length; i++)
        {
            Word w = new Word();
            string word = _wordList[i];
            if (_hiddenWords.Contains(i))
            {
                Console.Write($"{w.hide(_wordList[i])} ");
            }
            else
            {
                Console.Write($"{word} ");
            }
        }
        
    }

    public void DisplayComplScrip(){
        Console.WriteLine($"{_reference} {_scripture}.");
        Console.WriteLine("Press enter to continue or type quit to finish");
    }
    public void SetfinalRefer(string reference){
        _reference = reference;
            }
}

